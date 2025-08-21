namespace GenericCourses.Domain.Entities;

public class Category : Entity {
	public string? name { get; set; }
	public User user { get; set; }
	public Guid userId { get; set; }
}
