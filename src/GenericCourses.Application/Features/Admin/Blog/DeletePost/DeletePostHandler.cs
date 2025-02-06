using MediatR;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Admin.Blog;

public class DeletePostHandler : IRequestHandler<DeletePostRequest, bool> {
	private readonly IPostRepository _postRepository;

	public DeletePostHandler(IPostRepository postRepository) => _postRepository = postRepository;

	public async Task<bool> Handle(DeletePostRequest request, CancellationToken ct) {
		var post = await _postRepository.single(request.postId);
		if (post is null)
			throw new Exception("not found");

		await _postRepository.remove(post);

		return true;
	}

}
