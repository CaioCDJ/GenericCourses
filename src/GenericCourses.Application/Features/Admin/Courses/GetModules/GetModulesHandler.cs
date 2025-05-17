using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Admin.Courses.GetModules;

public class GetModulesHandler : IRequestHandler<GetModulesRequest, PaginatedList<GetModulesResponse>> {

	private readonly IModulesRepository _modulesRepository;
	private readonly ICourseRepository _courseRepository;

	public GetModulesHandler(IModulesRepository modulesRepository, ICourseRepository courseRepository) {
		_modulesRepository = modulesRepository;
		_courseRepository = courseRepository;
	}

	public async Task<PaginatedList<GetModulesResponse>> Handle(
			GetModulesRequest request, CancellationToken cancellationToken) {

		var course = await _courseRepository.single(request.course_id);

		if (course is null)
			throw new Exception();

		var lst = await _modulesRepository.paginate(request.course_id, request.pageIndex);
	
		var res_lst = new List<GetModulesResponse>();

		var qt = await _modulesRepository.countPagination(course.id);

		foreach (var item in lst) {
			res_lst.Add(new GetModulesResponse {
				id = item.id.ToString(),
				title = item.title,
				is_complete = item.complete
			});
		}

		return new PaginatedList<GetModulesResponse>(res_lst, qt, request.pageIndex,10);
	}

}
