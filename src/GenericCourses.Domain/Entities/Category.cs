namespace GenericCourses.Domain.Entities;

public class Category {
	public Guid id { get; set; } = Guid.NewGuid();
	public string? name { get; set; }
	public BlogPost? blogPost { get; set; }
	public Guid? blogPostId { get; set; }
	public Course? course { get; set; }
	public Guid? courseId { get; set; }
}
