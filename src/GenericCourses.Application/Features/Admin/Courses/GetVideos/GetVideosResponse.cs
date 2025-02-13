
namespace GenericCourses.Application.Features.Admin.Courses;

public record GetVideosResponse(
	string id,string title, string created_at, int order
);
