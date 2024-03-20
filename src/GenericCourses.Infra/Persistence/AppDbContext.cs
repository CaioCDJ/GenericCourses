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

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		var guid = Guid.NewGuid();

		// aumentando com o tempo
		Category[] categories = [
			new Category { category = "C#" },
			new Category { category = "Javascript" },
			new Category { category = "TypeScript" },
			new Category { category = "Laravel" },
			new Category { category = "Php" },
			new Category { category = "Banco de dados" },
			new Category { category = "Docker" },
			new Category { category = "Postgresql" },
			new Category { category = "C" },
			new Category { category = "C" },

		];

		var instructor = new Instructor {
			userId = guid
		};

		var posts = new Faker<BlogPost>("pt_BR")
		  .RuleFor(x => x.title, f => f.Commerce.Product())
		  .RuleFor(x => x.text, f => f.Lorem.Text())
		  .RuleFor(x => x.instructorId, f => f.PickRandomParam<Guid>([instructor.id]))
		  .RuleFor(x => x.categoryId, f => f.PickRandomParam<Guid>(
					  categories.Select(x => x.id).ToArray()));

		var data = posts.Generate(10);

		var user = new User {
			id = guid,
			email = "admin@admin.com",
			name = "admin",
			password = Hasing.hash("admin12345")
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

		modelBuilder.Entity<BlogPost>()
		  .HasData(data);
	}
}
