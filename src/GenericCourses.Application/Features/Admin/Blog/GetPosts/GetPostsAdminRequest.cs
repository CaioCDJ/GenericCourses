using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories.Queries;
using MediatR;

namespace GenericCourses.Application.Features.Admin.Blog;

public record GetPostsAdminRequest(
	Guid userId,
	int pageIndex,
	int pageSize = 8
	) : IRequest<PaginatedList<GetPostAdminQuery>>;
