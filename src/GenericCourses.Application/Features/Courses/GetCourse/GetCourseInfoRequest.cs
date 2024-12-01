using MediatR;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Courses.GetCourse;

public record GetCourseInfoRequest(Guid id)
		: IRequest<GenericCourses.Domain.Entities.Course>;
