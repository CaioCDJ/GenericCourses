namespace GenericCourses.Domain.Entities;

public class Module
{
    public Guid id { get; set; } = Guid.NewGuid();
    public string? title { get; set; }
    public string? description { get; set; }
    public int order { get; set; } = 0;
    public bool complete { get; set; } = false;
    public List<Video>? videos { get; set; }
}
