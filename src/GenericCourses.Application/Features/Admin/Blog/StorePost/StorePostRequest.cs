using System.ComponentModel.DataAnnotations;
using GenericCourses.Domain.Entities;
using MediatR;

namespace GenericCourses.Application.Features.Admin.Blog;

public class StorePostRequest: IRequest<BlogPost>
{
    [Required]
    public string title { get; set; }

    [Required]
    public string thumb { get; set; }

    public string[] categories { get; set; }

    [Required]
    public string text { get; set; }
    
    public Guid instructor_id { get; set; }
}
