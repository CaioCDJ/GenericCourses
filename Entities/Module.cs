namespace GenericCourses.Entities;

public class Module
{

    public Guid id { get; set; }
    public string title { get; set; }
    public string desc { get; set; }
    public List<Video> videos { get; set; }
    public Guid courseId { get; set; }
}
