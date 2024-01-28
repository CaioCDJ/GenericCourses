using System.ComponentModel.DataAnnotations.Schema;

namespace GenericCourses.Domain.Entities;

public class Course
{
    public Guid id { get; set; } = Guid.NewGuid();
    public string? title { get; set; }
    public string? description { get; set; }
    public string? thumb { get; set; }
    public bool isFree { get; set; } = false;
    public string? duration { get; set; }
    public List<Category>? categories { get; set; }
    public string? instrutor { get; set; }
    public bool active { get; set; }
    [Column(TypeName="Date")]
    public DateTime createdAt { get; set; } = DateTime.Now;
    [Column(TypeName="Date")]
    public DateTime lastupdate { get; set; } = DateTime.Now;
    public List<Module> modules { get; set; }
}
