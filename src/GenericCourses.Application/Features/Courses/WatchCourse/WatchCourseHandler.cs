using MediatR;
using GenericCourses.Domain.Entities;
using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Application.Features.Courses;

public record WatchCourseRequest(
	Guid course_id,
	Guid video_id,
	Guid user_id
) : IRequest<Result<WatchCourseResponse, Error>>;

public record WatchCourseResponse(
	Video current_video,
	List<Current_progress_query> course_queries
);

public class WatchCourseHandler : IRequestHandler<WatchCourseRequest, Result<WatchCourseResponse, Error>> {
	private readonly IStudentRepository _studentRepository;
	private readonly ICourseProgressRepository _courseProgressRepository;
	private readonly ICourseRepository _courseRepository;
	private readonly IVideosRepository _videosRepository;

	public WatchCourseHandler(
			IStudentRepository repository,
			ICourseProgressRepository courseProgrssRepository,
			ICourseRepository courseRepository,
			IVideosRepository videosRepository) {
		_studentRepository = repository;
		_courseProgressRepository = courseProgrssRepository;
		_courseRepository = courseRepository;
		_videosRepository = videosRepository;
	}

	public async Task<Result<WatchCourseResponse, Error>> Handle(WatchCourseRequest request, CancellationToken ct) {

		var course = await _courseRepository.single(request.course_id);

		if (course is null) return new Error("", "");

		var current_video = await _videosRepository.single(request.video_id);

		if (current_video is null) return new Error("", "");

		var videos = await _courseProgressRepository.current_progress(
				request.user_id, request.course_id);

		return videos is not null
			? new WatchCourseResponse(current_video, videos.ToList())
			: new Error("", "");
	}
}
