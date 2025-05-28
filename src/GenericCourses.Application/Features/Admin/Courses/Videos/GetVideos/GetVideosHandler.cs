using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Admin.Courses;

class GetVideosHandler : IRequestHandler<GetVideosRequest, PaginatedList<GetVideosResponse>> {

	private readonly IVideosRepository _videosRepository;
	private readonly IModulesRepository _modulesRepository;

	public GetVideosHandler(IVideosRepository repository, IModulesRepository modules_repository) {
		_videosRepository = repository;
		_modulesRepository = modules_repository;
	}

	public async Task<PaginatedList<GetVideosResponse>> Handle(GetVideosRequest request, CancellationToken ct) {

		var module = await _modulesRepository.single(request.module_id);

		if (module is null) {
			// exception
		}

		var items = await _videosRepository.paginate(request.module_id, request.page);

		var lst = new List<GetVideosResponse>();

		foreach (var item in items) {
			lst.Add(
				new GetVideosResponse(
					id: item.id.ToString(),
					title: item.title,
					order: item.order,
					created_at: item.created_at.ToString("dd/MM/yyyy")
				)
			);
		}

		return new PaginatedList<GetVideosResponse>(lst, lst.Count, request.page);
	}
}
