using MediatR;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Courses;

public record DisableCourseRequest(Guid id) : IRequest<Course>;
