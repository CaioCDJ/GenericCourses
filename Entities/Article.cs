namespace GenericCourses.Entities;

public class Article
{
    public Guid id { get; set; }
    public string title { get; set; }
    public string text { get; set; }
    public string userId { get; set; }
    public string thumb { get; set; }
    public DateTime created_at { get; set; }
    public List<Category>? categories { get; set; }
}
