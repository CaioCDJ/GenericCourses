using MediatR;
using GenericCourses.Infra.Repositories;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Courses.GetCourse;

public class GetCourseInfoHandler : IRequestHandler<GetCourseInfoRequest, Course>
{
	private readonly ICourseRepository _course_repository;

	public GetCourseInfoHandler(ICourseRepository course_repository) 
		=> _course_repository = course_repository;
	
	public async Task<Course> Handle(GetCourseInfoRequest request, CancellationToken cancellationToken) {
		return await _course_repository.single(request.id);
	}
}
