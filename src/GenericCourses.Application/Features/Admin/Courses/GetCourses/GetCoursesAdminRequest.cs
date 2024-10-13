using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Application.Features.Admin.Courses;

public record GetCoursesAdminRequest(
	int pageIndex,
	int pageSize = 8
	) : IRequest<PaginatedList<GetCoursesAdminResponse>>;
