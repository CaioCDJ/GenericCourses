using MediatR;
using GenericCourses.Application.Common;

namespace GenericCourses.Application.Features.Admin.Courses;

public record GetModulesRequest(
	int pageIndex,
	Guid course_id
	) : IRequest<PaginatedList<GetModulesResponse>>;
