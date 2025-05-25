using MediatR;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Blog;

public record UpdatePostRequest(
	Guid id, string title,
	string text, string thumb,
	string[] categories
) : IRequest<BlogPost>;
