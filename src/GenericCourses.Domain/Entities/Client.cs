namespace GenericCourses.Domain.Entities;

public class Client : Entity {

	public User user { get; set; }
	public Guid userId { get; set; }

	public ICollection<Review> reviews { get; set; }
}
