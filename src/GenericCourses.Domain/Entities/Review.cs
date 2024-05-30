using System.ComponentModel.DataAnnotations.Schema;

namespace GenericCourses.Domain.Entities;

public class Review {
	public Guid id { get; set; } = Guid.NewGuid();
	public string text { get; set; }
	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; }
	public Client client { get; set; }
	public Guid clientId { get; set; }
	public Course course { get; set; }
	public Guid courseId { get; set; }
}
