namespace GenericCourses.Domain.Entities;

public class Post
{
    public Guid id { get; set; }
    public string? title { get; set; }
    public string? text { get; set; }
    public string? userId { get; set; }
    public string? thumb { get; set; }
    public int acesses { get; set; }
    public DateTime created_at { get; set; } = DateTime.Now;
    public List<Category>? categories { get; set; }
}
