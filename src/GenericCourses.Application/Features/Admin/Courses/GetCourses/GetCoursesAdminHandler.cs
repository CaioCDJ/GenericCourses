using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Persistence;
using MediatR;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Application.Features.Admin.Courses;

public class GetCoursesAdminHandler : IRequestHandler<GetCoursesAdminRequest, PaginatedList<GetCoursesAdminResponse>> {

	private readonly ICourseRepository _courseRepository;
	private readonly IModulesRepository _modulesRepository;

	public GetCoursesAdminHandler(ICourseRepository courseRepository, IModulesRepository modulesRepository) {
		_courseRepository = courseRepository;
		_modulesRepository = modulesRepository;
	}

	public async Task<PaginatedList<GetCoursesAdminResponse>> Handle(
		GetCoursesAdminRequest request, CancellationToken ct
	) {

		var lst = await _courseRepository.paginateAdmin(
			size: request.pageSize,
			offset: request.pageIndex
		);

		var ids = lst.Select(item => item.id).ToArray();

		var qts = await _modulesRepository.countByCourse(ids);

		var res_lst = new List<GetCoursesAdminResponse>();

		foreach (var item in lst) {

			// int qt = (qts.Exists(x => x.id == item.id) ? qts.FirstOrDefault(x=>x.id==item.id).count :0 ;
			int qt = 0;

			if (qts.Exists(x => x.id == item.id)) {
				qt = qts.FirstOrDefault(x => x.id == item.id).count;
			}

			res_lst.Add(new GetCoursesAdminResponse {
				id = item.id.ToString(),
				title = item.title,
				instructor = item.name,
				active = item.active,
				is_free = item.is_free,
				created_at = item.created_at,
				updated_at = item.lastupdate,
				modules = qt,

			});
		}

		if (lst is null)
			return new PaginatedList<GetCoursesAdminResponse>(new List<GetCoursesAdminResponse>(), 0, request.pageIndex);

		var count = await _courseRepository.count();

		return new PaginatedList<GetCoursesAdminResponse>(res_lst, count, request.pageIndex);
	}
}
