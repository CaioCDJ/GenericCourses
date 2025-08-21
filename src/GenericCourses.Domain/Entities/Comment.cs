using System.ComponentModel.DataAnnotations.Schema;

namespace GenericCourses.Domain.Entities;

public class Comment : Entity {
	public string text { get; set; }
	public BlogPost blogPost { get; set; }
	public Guid blogPostId { get; set; }

	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; } = DateTime.Now;

}
