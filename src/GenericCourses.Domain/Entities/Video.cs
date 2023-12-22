namespace GenericCourses.Domain.Entities;

public class Video
{
    public Guid id { get; set; }
    public string? title { get; set; }
    public string? description { get; set; }
    public string? videoUrl { get; set; }
    public string? duration { get; set; }
    public int chapter { get; set; }
    public Guid moduleId{ get; set; }
}

