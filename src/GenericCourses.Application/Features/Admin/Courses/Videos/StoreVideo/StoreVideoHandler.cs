using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Courses;

public class StoreVideoHandler : IRequestHandler<StoreVideoRequest, Result<Video, Error>> {

	private readonly IVideosRepository _videosRepository;
	private readonly IModulesRepository _modulesRepository;

	public StoreVideoHandler(IVideosRepository videosRepository, IModulesRepository modulesRepository) {
		_videosRepository = videosRepository;
		_modulesRepository = modulesRepository;
	}

	public async Task<Result<Video, Error>> Handle(StoreVideoRequest request, CancellationToken ct) {

		if (await _modulesRepository.single(request.module_id) is null)
			return new Error("404", "Modulo não encontrado");

		var video = await _videosRepository.store(new Video() {
			title = request.title,
			description = request.desc,
			videoUrl = request.video_url,
			order = request.order,
			moduleId = request.module_id
		});

		return video is not null
			? video
			: new Error("400", "Erro ao adicionar um novo video");
	}
}
