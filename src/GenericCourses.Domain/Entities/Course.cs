namespace GenericCourses.Domain.Entities;

public class Course
{
    public Guid id { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public string? thumb { get; set; }
    public bool isFree { get; set; } = false;
    public string? duration { get; set; }
    public List<Category>? categories { get; set; }
    public string? instrutor { get; set; }
    public bool active { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime lastupdate { get; set; }
}
