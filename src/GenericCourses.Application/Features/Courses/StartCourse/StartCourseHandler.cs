using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Courses;

public record StartCourseRequest(
	Guid user_id,
	Guid course_id
) : IRequest<Result<Course, Error>>;

public class StartCourseHandler : IRequestHandler<StartCourseRequest, Result<Course, Error>> {

	private readonly ICourseRepository _courseRepository;
	private readonly ICourseProgressRepository _courseProgressRepository;
	private readonly IStudentRepository _studentRepository;

	public StartCourseHandler(
		ICourseProgressRepository courseProgrssRepository, ICourseRepository courseRepository,
		IStudentRepository studentRepository
	) {
		_courseRepository = courseRepository;
		_courseProgressRepository = courseProgrssRepository;
		_studentRepository = studentRepository;
	}

	public async Task<Result<Course, Error>> Handle(StartCourseRequest request, CancellationToken ct) {

		var student = await _studentRepository.SingleByUserId(request.user_id);

		if (student is null) return new Error("", "");

		var course = await _courseRepository.single(request.course_id);

		if (course is null) return new Error("", "");

		if (_courseProgressRepository.exists(request.course_id, request.user_id) is null)
			return new Error("", "");

		/// TODO: Verificar Planos

		return (_courseProgressRepository.store(
			new CourseProgress() {
				courseId = request.course_id,
				userId = request.user_id,
				done = false
			}) is not null)
		? course
		: new Error("", "");
	}
}
