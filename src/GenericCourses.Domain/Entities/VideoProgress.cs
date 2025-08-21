using GenericCourses.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

public class VideoProgress : Entity {

	public Video video { get; set; }
	public Guid videoId { get; set; }
	public Module module { get; set; }
	public Guid moduleId { get; set; }
	public bool done { get; set; } = false;

	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; } = DateTime.Now;
}
