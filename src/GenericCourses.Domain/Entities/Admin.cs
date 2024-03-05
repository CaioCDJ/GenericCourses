
namespace GenericCourses.Domain.Entities;

public class Admin {
	public Guid id { get; set; } = Guid.NewGuid();

	public User user { get; set; }
	public Guid userId { get; set; }
}
