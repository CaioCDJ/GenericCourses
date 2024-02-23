using System.ComponentModel.DataAnnotations;

namespace GenericCourses.Domain.Dtos.Forms;

public class NewPostDTO
{
    [Required]
    public string title { get; set; }

    [Required]
    public string thumb { get; set; }

    public string[] categories { get; set; }

    [Required]
    public string text { get; set; }
    
}
