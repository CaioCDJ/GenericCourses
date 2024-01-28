using System.ComponentModel.DataAnnotations.Schema;

namespace GenericCourses.Domain.Entities;

public class BlogPost
{
    public Guid id { get; set; } = Guid.NewGuid();
    public string? title { get; set; }
    public string? text { get; set; }
    public string? thumb { get; set; }
    public int acesses { get; set; } = 0;
    [Column(TypeName="Date")]
    public DateTime created_at { get; set; } = DateTime.Now;
    public List<Category>? categories { get; set; }
    public Guid userId { get; set; }
}
