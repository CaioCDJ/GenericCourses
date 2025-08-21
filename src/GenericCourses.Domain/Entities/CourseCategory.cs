namespace GenericCourses.Domain.Entities;

public class CourseCategory : Entity {
	public Course course { get; set; }
	public Guid courseId { get; set; }
	public Category category { get; set; }
	public Guid categoryId { get; set; }
}
