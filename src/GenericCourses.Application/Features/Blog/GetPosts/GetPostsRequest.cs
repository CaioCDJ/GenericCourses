using MediatR;
using GenericCourses.Infra.Repositories;
using GenericCourses.Application.Common;
using GenericCourses.Domain.Dtos.Pages;

namespace GenericCourses.Application.Features.Blog;

public record GetPostsRequest(
	int pageIndex,
	int pageSize = 8,
	string[]? categories = null,
	string? searchParam = null
	) : IRequest<PaginatedList<PostDTO>>;
