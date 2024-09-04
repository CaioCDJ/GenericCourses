using System.ComponentModel.DataAnnotations.Schema;

namespace GenericCourses.Domain.Entities;

public class User_Plan {

	public Guid id { get; set; } = Guid.NewGuid();
	public Client client { get; set; }
	public Guid clientId { get; set; }
	public Subscriptionplan subscriptionplan { get; set; }
	public Guid subscriptionplanId { get; set; }
	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; } = DateTime.Now;
	public bool is_active { get; set; } = true;
}
