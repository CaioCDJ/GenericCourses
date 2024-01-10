using Microsoft.EntityFrameworkCore;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Infra.Persistence;

public class AppDbContext : DbContext{

  public DbSet<Category> categories{ get; set; }
  public DbSet<Certificate> certificates{ get; set; }
  public DbSet<Course> courses { get; set; }
  public DbSet<Module> modules { get; set; }
  public DbSet<ModuleProgress> moduleProgresses { get; set; }
  public DbSet<Post> posts{ get; set; }
  public DbSet<CourseProgress> CourseProgresses { get; set; }
  public DbSet<Subscriptionplan> subscriptionplans { get; set; }
  public DbSet<User> users{ get; set; }
  public DbSet<Video> videos { get; set; }
  public DbSet<VideoProgress>VideoProgresses  { get; set; }

  public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
}
