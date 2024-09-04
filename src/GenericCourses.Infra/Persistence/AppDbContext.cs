using Microsoft.EntityFrameworkCore;
using GenericCourses.Domain.Entities;
using Bogus;
using Bogus.Extensions.Brazil;
using GenericCourses.Infra.Security;

namespace GenericCourses.Infra.Persistence;

public class AppDbContext : DbContext {


	public DbSet<Certificate> certificates { get; set; }
	public DbSet<Course> courses { get; set; }
	public DbSet<Module> modules { get; set; }
	public DbSet<ModuleProgress> modules_progress { get; set; }
	public DbSet<BlogPost> blog_posts { get; set; }
	public DbSet<CourseProgress> course_Progresses { get; set; }
	public DbSet<Subscriptionplan> subscription_plans { get; set; }
	public DbSet<User> users { get; set; }
	public DbSet<Client> clients { get; set; }
	public DbSet<User_Plan> user_plan { get; set; }
	public DbSet<Admin> admins { get; set; }
	public DbSet<Category> categories { get; set; }
	public DbSet<Instructor> instructors { get; set; }
	public DbSet<Video> videos { get; set; }
	public DbSet<VideoProgress> video_progresses { get; set; }
	public DbSet<Comment> comments { get; set; }
	public DbSet<Review> reviews { get; set; }
	public DbSet<PostCategory> post_categories { get; set; }
	public DbSet<CourseCategory> course_categories { get; set; }

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder) {

		var instructorId = Guid.NewGuid();
		var adminId = Guid.NewGuid();

		var clientsUser = new Faker<User>("pt_BR")
			.RuleFor(u => u.id, f => Guid.NewGuid())
			.RuleFor(u => u.name, f => f.Person.FullName)
			.RuleFor(u => u.email, f => f.Internet.Email())
			.RuleFor(u => u.password, f => Hasing.hash(f.Internet.Password()))
			.RuleFor(u => u.cpf, f => double.Parse(f.Person.Cpf().Replace(".", "").Replace("-", "")))
			.RuleFor(u => u.phone, f => double.Parse(f.Person.Phone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")))
			.RuleFor(u => u.is_active, f => true)
			.RuleFor(u => u.created_at, f => DateTime.Now);

		var usersList = clientsUser.Generate(50);

		var clientsId = usersList.Select(x => x.id).ToArray();

		usersList.Add(
			new User {
				id = adminId,
				name = "Admin",
				email = "admin@admin",
				password = Hasing.hash("admin123"),
				cpf = 123456789,
				phone = 123456789,
				is_active = true,
				created_at = DateTime.Now
			}
		);

		usersList.Add(
			new User {
				id = instructorId,
				name = "instrutor 1",
				email = "professor@preofessor.com",
				password = Hasing.hash("professor123"),
				cpf = 123456789,
				phone = 123456789,
				is_active = true,
				created_at = DateTime.Now
			}
		);

		// default acconts
		modelBuilder.Entity<User>().HasData(usersList);

		var admin =
			new Admin {
				userId = adminId
			};

		modelBuilder.Entity<Admin>().HasData(admin);

		var instrutor = new Instructor {
			userId = instructorId
		};

		modelBuilder.Entity<Instructor>().HasData(instrutor);

		var freePlanId = Guid.NewGuid();
		// Subs
		modelBuilder.Entity<Subscriptionplan>().HasData(
			new Subscriptionplan {
				id = freePlanId,
				price = 0,
				description = "Free",
				created_at = DateTime.Now,
				months = 0,
				adminId = admin.id
			},

			new Subscriptionplan {
				price = 35.0f,
				description = "Mensal",
				created_at = DateTime.Now,
				months = 1,
				adminId = admin.id
			},

			new Subscriptionplan {
				price = 399.99f,
				description = "Anual",
				created_at = DateTime.Now,
				months = 1,
				adminId = admin.id
			}
		);

		var clientData = new List<Client>();


		for (int i = 0; i < clientsId.Count(); i++)
			clientData.Add(new Client { userId = clientsId[i] });

		modelBuilder.Entity<Client>().HasData(clientData);

		// User_Plan

		var subs_client = new List<User_Plan>();
		for (int i = 0; i < clientsId.Count(); i++)
			subs_client.Add(
				new User_Plan() {
					subscriptionplanId = freePlanId,
					clientId = clientData[i].id
				}
		);

		modelBuilder.Entity<User_Plan>().HasData(subs_client);


		/// Blog Post
		var blogPostFaker = new Faker<BlogPost>("pt_BR")
			.RuleFor(u => u.id, f => f.Random.Guid())
			.RuleFor(u => u.instructorId, f => instrutor.id)
			.RuleFor(u => u.text, f => f.Lorem.Paragraphs())
			.RuleFor(u => u.title, f => f.Name.JobArea());

		var posts = blogPostFaker.Generate(30);


		modelBuilder.Entity<BlogPost>()
			.HasData(posts);

		var categories = new List<Category>(){
			new Category{name = "c#", userId = adminId },
			new Category{name = "c", userId = adminId },
			new Category{name = "Js", userId = adminId },
			new Category{name = "Java", userId = adminId },
			new Category{name = "Typescript", userId = adminId },
			new Category{name = "PHP", userId = adminId },
			new Category{name = "MySql", userId = adminId },
			new Category{name = "SQL", userId = adminId },
			new Category{name = "Rust", userId = adminId },
			new Category{name = "F#", userId = adminId },
		};

		var rdm = new Random();

		modelBuilder.Entity<Category>()
			.HasData(categories);

		var categoriesPost = new List<PostCategory>();

		for (int i = 0; i < posts.Count; i++) {
			categoriesPost.Add(
				new PostCategory {
					categoryId = categories[rdm.Next(0, categories.Count)].id,
					blogPostId = posts[i].id
				}
			);
		}

		modelBuilder.Entity<PostCategory>()
			.HasData(categoriesPost);


		// -- Courses -- 

		var courseFaker = new Faker<Course>("pt_BR")
			.RuleFor(x => x.title, f => f.Commerce.Product())
			.RuleFor(x => x.description, f => f.Lorem.Paragraph())
			.RuleFor(x => x.active, f => true)
			.RuleFor(x => x.is_free, f => false)// tudo que e bom tem um preco, e o mmeu e inflacionado.
			.RuleFor(x => x.instructorId, f => instrutor.id);

		var coures = courseFaker.Generate(14);

		var freeCourseId = Guid.NewGuid();

		coures.Add(
			new Course {
				id = freeCourseId,
				title = "Curso de baixa qualidade",
				is_free = true,
				instructorId = instrutor.id,
				active = true,
			});

		modelBuilder.Entity<Course>()
			.HasData(coures);

		modelBuilder.Entity<Module>().HasData(
			new Module {
				title = "introducao",
				courseId = freeCourseId
			},
			new Module {
				title = "Modulo 2",
				courseId = freeCourseId,
				order = 1
			},
			new Module {
				title = "Modulo 3",
				courseId = freeCourseId,
				order = 2
			}
		);
	}
}
