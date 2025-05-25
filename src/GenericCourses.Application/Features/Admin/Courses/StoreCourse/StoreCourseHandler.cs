using MediatR;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Admin.Courses;

public class StoreCourseHandler : IRequestHandler<StoreCourseRequest, Course> {

	private readonly ICourseRepository _courseRepository;
	private readonly IInstructorRepository _instructorRepository;

	public StoreCourseHandler(ICourseRepository courseRepository, IInstructorRepository instructorRepository) {
		_instructorRepository = instructorRepository;
		_courseRepository = courseRepository;
	}

	public async Task<Course> Handle(StoreCourseRequest request, CancellationToken ct) {

		var instructor_guid = Guid.Parse(request.instructor_id);

		var instructor = await _instructorRepository.single(instructor_guid);

		if (instructor is null) { }

		var course = await _courseRepository.store(new Course {
			title = request.title,
			description = request.description ?? "",
			thumb = request.thumb ?? "",
			is_free = request.is_free,
			instructorId = instructor.id,
			active = request.active
		});

		return course;
	}
}

