using System.ComponentModel.DataAnnotations.Schema;
namespace GenericCourses.Domain.Entities;

public class Certificate : Entity {

	public Course course { get; set; }
	public Guid? courseId { get; set; }
	[Column(TypeName = "Date")]
	public DateTime emited_at { get; set; } = DateTime.Now;
	public User user { get; set; }
	public Guid userId { get; set; }
}
