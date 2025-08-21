namespace GenericCourses.Domain.Entities;

public class PostCategory : Entity {
	public BlogPost blogPost { get; set; }
	public Guid blogPostId { get; set; }
	public Category category { get; set; }
	public Guid categoryId { get; set; }
}
