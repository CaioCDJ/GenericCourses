namespace GenericCourses.Infra.Repositories.Queries;

public class GetPostAdminQuery {
	public Guid postId { get; set; }
	public string title { get; set; }
	public string author { get; set; }
	public DateTime created_at { get; set; }
}
