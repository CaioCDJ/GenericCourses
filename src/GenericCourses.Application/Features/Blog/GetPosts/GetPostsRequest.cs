using MediatR;

namespace GenericCourses.Application.Features.Blog;

public record GetPostsRequest(
	int pageIndex,
	int pageSize = 8,
	string[]? categories = null,
	string? searchParam = null
	) : IRequest<GetPostsResponse>;
