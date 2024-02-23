using System.ComponentModel.DataAnnotations;

namespace GenericCourses.Domain.Dtos.Forms;

public class RegisterDTO
{
    [Required]
    public string name { get; set; }
    [Required]
    [EmailAddress]
    public string email { get; set; }
    public int phoneNumber { get; set; }
    [Required]
    public int cpf { get; set; }
     [Required]
    [DataType(DataType.Password)]
    public string password { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string confirmPassword { get; set; }
}
