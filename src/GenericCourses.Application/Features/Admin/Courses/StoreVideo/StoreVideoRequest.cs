using MediatR;
using GenericCourses.Application.Common;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Courses;

public record StoreVideoRequest(
	string title,
	int order,
	string video_url,
	string desc,
	Guid module_id
):IRequest<Result<Video, Error>>;
