using MediatR;
using GenericCourses.Application.Common;

namespace GenericCourses.Application.Features.Admin.Courses;

public record GetVideosRequest(
	Guid module_id,
	int page = 1
) : IRequest<PaginatedList<GetVideosResponse>>;
