namespace GenericCourses.Domain.Entities;

public class Instructor {

	public Guid id { get; set; } = Guid.NewGuid();
	public User user { get; set; }
	public Guid userId { get; set; }
	public string? social_network { get; set; }
	public string? github { get; set; } // why not?
	public ICollection<BlogPost>? posts { get; set; }
}
