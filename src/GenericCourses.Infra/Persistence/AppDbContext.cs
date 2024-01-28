using Microsoft.EntityFrameworkCore;
using GenericCourses.Domain.Entities;
using Bogus;
using Bogus.Extensions.Brazil;

namespace GenericCourses.Infra.Persistence;

public class AppDbContext : DbContext
{

    public DbSet<Category> categories { get; set; }
    public DbSet<Certificate> certificates { get; set; }
    public DbSet<Course> courses { get; set; }
    public DbSet<Module> modules { get; set; }
    public DbSet<ModuleProgress> moduleProgresses { get; set; }
    public DbSet<BlogPost> blogPosts { get; set; }
    public DbSet<CourseProgress> CourseProgresses { get; set; }
    public DbSet<Subscriptionplan> subscriptionplans { get; set; }
    public DbSet<User> users { get; set; }
    public DbSet<Video> videos { get; set; }
    public DbSet<VideoProgress> VideoProgresses { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var guid = Guid.NewGuid();

        var posts = new Faker<BlogPost>("pt_BR")
          .RuleFor(x => x.title, f => f.Commerce.Product())
          .RuleFor(x => x.text, f => f.Lorem.Text())
          .RuleFor(x=>x.userId,f=>f.PickRandomParam<Guid>([guid]));

        var data =  posts.Generate(10);

        var user = new User
        {
            id = guid,
            email = "admin@admin.com",
            name = "admin",
        };

        modelBuilder.Entity<User>()
            .HasData(
             user
          );

        modelBuilder.Entity<User>()
          .HasData(new User
          {
              id = Guid.NewGuid(),
              email = "user@email.com",
              name = "user"
          });

        modelBuilder.Entity<BlogPost>()
          .HasData(posts.Generate(10));

    }
}
