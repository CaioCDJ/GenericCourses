namespace GenericCourses.Domain.Entities;

public class PostCategory {
	public Guid id { get; set; } = Guid.NewGuid();
	public BlogPost blogPost { get; set; }
	public Guid blogPostId { get; set; }
	public Category category { get; set; }
	public Guid categoryId { get; set; }
}
