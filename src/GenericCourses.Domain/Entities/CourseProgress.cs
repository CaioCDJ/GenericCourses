using GenericCourses.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

public class CourseProgress : Entity {

	public User user { get; set; }
	public Guid userId { get; set; }
	public Course Course { get; set; }
	public Guid courseId { get; set; }
	public bool done { get; set; } = false;

	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; } = DateTime.Now;
}
