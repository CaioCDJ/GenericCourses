using System.ComponentModel.DataAnnotations.Schema;
namespace GenericCourses.Domain.Entities;

public class User {
	public Guid id { get; set; } = new Guid();
	public string name { get; set; }
	public string email { get; set; }
	public string password { get; set; }
	public int cpf { get; set; }
	public int? phone { get; set; }
	public bool is_active { get; set; } = true;
	[Column(TypeName = "Date")]
	public DateTime created_at { get; set; } = DateTime.Now;
}
