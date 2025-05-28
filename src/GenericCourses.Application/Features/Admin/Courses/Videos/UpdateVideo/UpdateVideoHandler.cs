using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Admin.Courses;

public record UpdateVideoRequest(
	string ?title,
	string ?description,
	string ?videoUrl,
	int? order,
	Guid id
) : IRequest<Result<Video, Error>>;

public class UpdateVideoHandler : IRequestHandler<UpdateVideoRequest, Result<Video, Error>> {

	private readonly IVideosRepository _videosRepository;

	public UpdateVideoHandler(IVideosRepository videosRepository)
		=> _videosRepository = videosRepository;

	public async Task<Result<Video, Error>> Handle(UpdateVideoRequest request, CancellationToken ct) {

		var video = await _videosRepository.single(request.id);

		if (video is null)
			return new Error("400", "Video não encontro!");

		video.title = request.title ?? video.title;
		video.description = request.description ?? video.description;
		video.videoUrl = request.videoUrl ?? video.videoUrl;
		video.order = (request.order.HasValue) ? request.order.Value : video.order;

		await _videosRepository.update(video);
		return video;
	}
}
