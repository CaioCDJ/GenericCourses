using MediatR;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Courses;

public record StoreModuleRequest(
	Guid course_id, string title, string description
) : IRequest<Module>;
