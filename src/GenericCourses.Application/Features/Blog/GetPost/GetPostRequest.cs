using MediatR;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Blog;

public record GetPostRequest(Guid id) : IRequest<BlogPost>;
