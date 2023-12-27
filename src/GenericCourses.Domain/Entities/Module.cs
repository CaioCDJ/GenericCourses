namespace GenericCourses.Domain.Entities;

public class Module
{

    public Guid id { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public int order { get; set; } = 0;
    public List<Video>? videos { get; set; }
    public Guid courseId { get; set; }
}
