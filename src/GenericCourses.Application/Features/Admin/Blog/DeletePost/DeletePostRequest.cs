using MediatR;

namespace GenericCourses.Application.Features.Admin.Blog;

public record DeletePostRequest(Guid postId) : IRequest<bool>;
