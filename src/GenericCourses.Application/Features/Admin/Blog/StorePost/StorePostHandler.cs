using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories;
using MediatR;

namespace GenericCourses.Application.Features.Admin.Blog;

public class StorePostHandler : IRequestHandler<StorePostRequest, BlogPost> {

	private readonly PostRepository _postRepository;

	public StorePostHandler(PostRepository postRepository) => _postRepository = postRepository;

	public async Task<BlogPost> Handle(StorePostRequest request, CancellationToken ct) {

		var post = await _postRepository.store(new BlogPost {
			title = request.title,
			text = request.text,
			thumb = request.thumb,
			instructorId = request.instructor_id
		});

		if (post is null)
			throw new Exception();


		return post;
	}
}

