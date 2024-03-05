using GenericCourses.Domain.Entities;

public class CourseProgress {
	public Guid id { get; set; }

	public User user { get; set; }
	public Course Course { get; set; }
	public Guid clientId { get; set; }
	public Guid courseId { get; set; }
	public bool done { get; set; } = false;
}
