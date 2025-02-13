using GenericCourses.Application.Features.Courses;
using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;
using GenericCourses.Domain.Entities;
using MediatR;

public class GetCoursesHandler : IRequestHandler<GetCoursesRequest, PaginatedList<Course>> {

	private readonly ICourseRepository _courses_repository;

	public GetCoursesHandler(ICourseRepository repository)
		=> _courses_repository = repository;

	public async Task<PaginatedList<Course>> Handle(GetCoursesRequest request, CancellationToken cancellationToken) {

		var lst = await _courses_repository.paginate(request.page);

		int qt = await _courses_repository.count();

		return new PaginatedList<Course>(
		  lst, qt, 4, 0
		);
	}
}
