using GenericCourses.Domain.Entities;

namespace GenericCourses.Domain.Dtos.Pages;

public class AdminAccountDTO
{
    public string name { get; set; }
    public string email { get; set; }
    public string imgUrl { get; set; }

    public int qtCourses { get; set; }
    public int qtBlogPosts { get; set; }
    public int qtStudentsFinished { get; set; }
    public int qtStudents { get; set; }
    public IEnumerable<BlogPost>? lastPosts { get; set; }
    public IEnumerable<Course>? lastCourses { get; set; }

}
