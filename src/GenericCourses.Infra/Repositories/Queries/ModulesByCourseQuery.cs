namespace GenericCourses.Infra.Repositories.Queries;

public class ModulesByCourseQuery {
	public Guid id { get; set; }
	public string title { get; set; }
	public bool complete { get; set; }
	public DateTime created_at { get; set; }
}
