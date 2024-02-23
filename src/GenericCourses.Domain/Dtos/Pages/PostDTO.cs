namespace GenericCourses.Domain.Dtos.Pages;

public class PostDTO
{
    public Guid postId { get; set; }
    public string title { get; init; }
    public DateTime date { get; init; }
    public string author { get; init; }
    public string? category{ get; init; } = "";
}
