using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Courses;

public class DeleteVideoHandler : IRequestHandler<DeleteVideoRequest, Result<Video, Error>> {

	private readonly IVideosRepository _videosRepository;
	private readonly IModulesRepository _modulesRepository;

	public DeleteVideoHandler(IVideosRepository videosRepository, IModulesRepository modulesRepository) {
		_modulesRepository = modulesRepository;
		_videosRepository = videosRepository;
	}

	public async Task<Result<Video, Error>> Handle(DeleteVideoRequest request, CancellationToken ct) {
		
		if(await _modulesRepository.single(request.moduleId) is null)
			return new Error("404", "Modulo não encontrado");
		
		var video = await _videosRepository.single(request.video_id);

		if( video is null)
			return new Error("404", "Video não encontrado");

		await _videosRepository.remove(video);

		return video;
	}
}
