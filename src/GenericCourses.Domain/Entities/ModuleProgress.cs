using GenericCourses.Domain.Entities;

public class ModuleProgress {

	public Guid id { get; set; } = Guid.NewGuid();
	public Module module { get; set; }
	public Guid moduleId { get; set; }
	public CourseProgress course_progress { get; set; }
	public Guid courseProgressId { get; set; }

	public bool done { get; set; } = false;
}
