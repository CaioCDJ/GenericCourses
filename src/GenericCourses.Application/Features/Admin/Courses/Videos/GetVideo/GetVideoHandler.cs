using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Admin.Courses;

public record GetVideoRequest(Guid id) : IRequest<Result<Video, Error>>;

public class GetVideoHandler : IRequestHandler<GetVideoRequest, Result<Video, Error>> {

	private readonly IVideosRepository _videosRepository;

	public GetVideoHandler(IVideosRepository videosRepository)
		=> _videosRepository = videosRepository;

	public async Task<Result<Video, Error>> Handle(GetVideoRequest request, CancellationToken ct){

		var video = await _videosRepository.single(request.id);

		return video is not null
			? video
			: new Error("404","Video não encontrado");
	}
}


