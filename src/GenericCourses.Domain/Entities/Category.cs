namespace GenericCourses.Domain.Entities;

public class Category {
	public Guid id { get; set; } = Guid.NewGuid();
	public string? name { get; set; }
	public User user { get; set; }
	public Guid userId { get; set; }
}
