using System.ComponentModel.DataAnnotations.Schema;

namespace GenericCourses.Domain.Entities;

public class Subscriptionplan {
	public Guid id { get; set; } = Guid.NewGuid();
	public float price { get; set; }
	public string description { get; set; }
	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; } = DateTime.Now;
	public List<Client> clients { get; set; }
	public int months { get; set; }
}
