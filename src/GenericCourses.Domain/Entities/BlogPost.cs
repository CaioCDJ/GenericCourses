using System.ComponentModel.DataAnnotations.Schema;

namespace GenericCourses.Domain.Entities;

public class BlogPost : Entity {
	public string? title { get; set; }
	public string? text { get; set; }
	public string? thumb { get; set; }
	public int acesses { get; set; } = 0;
	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; } = DateTime.Now;
	public ICollection<PostCategory>? postCategories { get; set; }
	public Instructor instructor { get; set; }
	public Guid instructorId { get; set; }
	public ICollection<Comment>? comments { get; set; }
}
