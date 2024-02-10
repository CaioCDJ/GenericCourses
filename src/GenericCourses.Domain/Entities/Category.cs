namespace GenericCourses.Domain.Entities;

public class Category
{
    public Guid id { get; set; }= Guid.NewGuid();
    public string? category { get; set; }
}
