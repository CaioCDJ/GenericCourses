using GenericCourses.Application.Common;
using GenericCourses.Domain.Dtos.Pages;

namespace GenericCourses.Application.Features.Blog;

public record GetPostsResponse(
	PaginatedList<PostDTO> Posts,
	string[]? categories
);
