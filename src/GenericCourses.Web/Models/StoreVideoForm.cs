using GenericCourses.Application.Features.Admin.Courses;

namespace GenericCourses.Web.Models;

public class StoreVideoForm{
	public string title { get; set; }
	public int order { get; set; }
	public string video_url { get; set; }
	public string desc { get; set; }
}
