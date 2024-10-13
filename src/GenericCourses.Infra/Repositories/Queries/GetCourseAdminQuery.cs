namespace GenericCourses.Infra.Repositories.Queries;

public class GetCourseAdminQuery {
	public Guid id { get; set; }
	public string title { get; set; }
	public bool is_free { get; set; }
	public bool active { get; set; }
	public DateTime created_at { get; set; }
	public DateTime lastupdate { get; set; }
	public string name { get; set; }
}
