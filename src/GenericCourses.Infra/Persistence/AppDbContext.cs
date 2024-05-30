using Microsoft.EntityFrameworkCore;
using GenericCourses.Domain.Entities;
using Bogus;
using Bogus.Extensions.Brazil;
using GenericCourses.Infra.Security;

namespace GenericCourses.Infra.Persistence;

public class AppDbContext : DbContext {

	public DbSet<Category> categories { get; set; }
	public DbSet<Certificate> certificates { get; set; }
	public DbSet<Course> courses { get; set; }
	public DbSet<Module> modules { get; set; }
	public DbSet<ModuleProgress> modules_progress { get; set; }
	public DbSet<BlogPost> blog_posts { get; set; }
	public DbSet<CourseProgress> course_Progresses { get; set; }
	public DbSet<Subscriptionplan> subscription_plans { get; set; }
	public DbSet<User> users { get; set; }
	public DbSet<Client> clients { get; set; }
	public DbSet<Admin> admins { get; set; }
	public DbSet<Instructor> instructors { get; set; }
	public DbSet<Video> videos { get; set; }
	public DbSet<VideoProgress> video_progresses { get; set; }
	public DbSet<Comment> comments { get; set; }
	public DbSet<Review> reviews { get; set; }

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		var guid = Guid.NewGuid();
		/*
				// aumentando com o tempo
				Category[] categories = [
					new Category { name = "C#" },
					new Category { name = "Javascript" },
					new Category { name = "TypeScript" },
					new Category { name = "Laravel" },
					new Category { name = "Php" },
					new Category { name = "Banco de dados" },
					new Category { name = "Docker" },
					new Category { name = "Postgresql" },
					new Category { name = "C" },
					new Category { name = "C" },
				];

				var instructor = new Instructor {
					userId = guid
				};
				//
				// var posts = new Faker<BlogPost>("pt_BR")
				//   .RuleFor(x => x.title, f => f.Commerce.Product())
				//   .RuleFor(x => x.text, f => f.Lorem.Text())
				//   .RuleFor(x => x.instructorId, f => f.PickRandomParam<Guid>([instructor.id]));
				//
				// var data = posts.Generate(10);
				//
				// foreach(var item in data){
				// 	item.category.Add(categories[new Random().Next(0, categories.Length)]);
				// }

				var user = new User {
					id = guid,
					email = "admin@admin.com",
					name = "admin",
					password = Hasing.hash("admin12345")
				};

				var coursesFaker = new Faker<Course>("pt_BR")
				  .RuleFor(x => x.title, f => f.Commerce.Product())
				  .RuleFor(x => x.description, f => f.Lorem.Text())
				  .RuleFor(x=>x.is_free, f => f.Random.Bool(0.5f))
				  .RuleFor(x=>x.active, f => f.Random.Bool(0.5f))
				  .RuleFor(x => x.instructorId, f => f.PickRandomParam<Guid>([instructor.id]));

				var courses = coursesFaker.Generate(15);

				var subscriptionPlan = new List<Subscriptionplan>{
					new Subscriptionplan{
						description = "Plano mensal",
						price = 15.00f,
						months = 1
					},
					new Subscriptionplan{
						description = "Plano anual",
						price = 150.00f,
						months = 12
					}
				};

				modelBuilder.Entity<User>()
					.HasData(
					 user
				  );

				modelBuilder.Entity<Instructor>()
					.HasData(instructor);

				modelBuilder.Entity<User>()
				  .HasData(new User {
					  id = Guid.NewGuid(),
					  email = "user@email.com",
					  name = "user",
					  password = Hasing.hash("algo4321")
				  });

				modelBuilder.Entity<Category>()
					.HasData(categories);

				// // modelBuilder.Entity<BlogPost>()
				// //   .HasData(data);


				for(int i =0;i< courses.Count;i++) {
					courses[i].instructorId = instructor.id;
					// var cats = categories.Take(Random.Shared.Next(0,categories.Length )).ToList();
					// courses[i].categories = cats;
				}

				// modelBuilder.Entity<Course>()
				// 	.HasData(courses);

				modelBuilder.Entity<Subscriptionplan>();*/
	}
}
