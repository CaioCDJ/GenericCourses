using MediatR;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Blog;

public class UpdatePostHandler : IRequestHandler<UpdatePostRequest, BlogPost> {

	private readonly IPostRepository _postRepository;

	public UpdatePostHandler(IPostRepository postRepository)
		=> _postRepository = postRepository;

	public async Task<BlogPost> Handle(UpdatePostRequest request, CancellationToken ct) {

		var current_post = await _postRepository.single(request.id);

		if (current_post is null) { } //errors

		current_post.title = string.IsNullOrEmpty(request.title)
			? current_post.title : request.title;
		current_post.text = string.IsNullOrEmpty(request.text)
			? current_post.text : request.text;
		current_post.thumb = string.IsNullOrEmpty(request.thumb)
			? current_post.thumb : request.thumb;

		await _postRepository.update(current_post);

		return current_post;
	}
}
