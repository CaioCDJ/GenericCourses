namespace GenericCourses.Domain.Entities;

public class Post
{
    public Guid id { get; set; } = Guid.NewGuid();
    public string? title { get; set; }
    public string? text { get; set; }
    public string? userId { get; set; }
    public string? thumb { get; set; }
    public int acesses { get; set; } = 0;
    public DateTime created_at { get; set; } = DateTime.Now;
    public List<Category>? categories { get; set; }
}
