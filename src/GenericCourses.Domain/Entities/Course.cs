using System.ComponentModel.DataAnnotations.Schema;

namespace GenericCourses.Domain.Entities;

public class Course {
	public Guid id { get; set; } = Guid.NewGuid();
	public string? title { get; set; }
	public string? description { get; set; }
	public string? thumb { get; set; }
	public bool is_free { get; set; } = false;
	public string? duration { get; set; }
	public ICollection<CourseCategory>? courseCategories { get; set; }
	public Instructor instructor { get; set; }
	public Guid instructorId { get; set; }
	public bool active { get; set; }
	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; } = DateTime.Now;
	[Column(TypeName = "Date")]
	public DateTime lastupdate { get; set; } = DateTime.Now;
	public ICollection<Module>? modules { get; set; }
	public ICollection<Review>? reviews { get; set; }
}
