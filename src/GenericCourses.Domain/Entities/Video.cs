namespace GenericCourses.Domain.Entities;

public class Video
{
    public Guid id { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public string? videoUrl { get; set; }
    public string? duration { get; set; }
    public int order { get; set; }
    public DateTime created_at { get; set; }
    public Guid moduleId{ get; set; }
}
