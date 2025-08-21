
namespace GenericCourses.Domain.Entities;

public class Admin: Entity {

	public User user { get; set; }
	public Guid userId { get; set; }
}
