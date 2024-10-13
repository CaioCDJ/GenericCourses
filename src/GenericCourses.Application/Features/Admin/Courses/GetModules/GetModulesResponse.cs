namespace GenericCourses.Application.Features.Admin.Courses;

public class GetModulesResponse {
	public string id { get; set; }
	public string title { get; set; }
	public bool is_complete { get; set; }
	public DateTime created_at { get; set; }
	public int qt_videos { get; set; } = 0;
}
