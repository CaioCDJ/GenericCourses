using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Courses;

public record DeleteVideoRequest(
	Guid moduleId,
	Guid video_id
):IRequest<Result<Video, Error>>;
