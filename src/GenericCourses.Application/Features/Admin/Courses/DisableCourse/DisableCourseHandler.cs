using MediatR;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Admin.Courses;

public class DisableCourseHandler : IRequestHandler<DisableCourseRequest, Course> {

	private ICourseRepository _courseRepository;

	public DisableCourseHandler(ICourseRepository courseRepository)
		=> _courseRepository = courseRepository;

	public async Task<Course> Handle(DisableCourseRequest request, CancellationToken ct) {

		var course = await _courseRepository.single(request.id);

		if (course is null) { }

		course.active = false;

		var upataded_course = await _courseRepository.update(course);

		return upataded_course;
	}
}
