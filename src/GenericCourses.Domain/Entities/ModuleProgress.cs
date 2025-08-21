using System.ComponentModel.DataAnnotations.Schema;
using GenericCourses.Domain.Entities;

public class ModuleProgress : Entity {

	public Module module { get; set; }
	public Guid moduleId { get; set; }
	public CourseProgress course_progress { get; set; }
	public Guid courseProgressId { get; set; }
	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; } = DateTime.Now;

	public bool done { get; set; } = false;
}
