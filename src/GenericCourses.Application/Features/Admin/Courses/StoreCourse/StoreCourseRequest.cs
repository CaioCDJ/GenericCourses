using MediatR;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Courses;

public record StoreCourseRequest(
	string title,
	string? description,
	string? thumb,
	bool is_free,
	string instructor_id,
	bool active
): IRequest<Course>;
