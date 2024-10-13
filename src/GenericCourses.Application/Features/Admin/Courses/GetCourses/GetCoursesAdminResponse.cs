namespace GenericCourses.Application.Features.Admin.Courses;

public class GetCoursesAdminResponse {
	public string id { get; set; }
	public string title { get; set; }
	public string instructor { get; set; }
	public bool active { get; set; }
	public bool is_free { get; set; }
	public DateTime created_at { get; set; }
	public DateTime updated_at { get; set; }
	public int modules { get; set; }
}
