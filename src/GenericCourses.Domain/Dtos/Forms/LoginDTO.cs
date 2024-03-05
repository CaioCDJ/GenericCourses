using System.ComponentModel.DataAnnotations;

namespace GenericCourses.Domain.Dtos.Forms;

public class LoginDTO {
	[Required]
	[EmailAddress]
	public string email { get; set; }
	[Required]
	[DataType(DataType.Password)]
	public string password { get; set; }
}
