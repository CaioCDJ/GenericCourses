using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Courses;

public record GetCoursesRequest(int page = 1) : IRequest<PaginatedList<Course>>;
