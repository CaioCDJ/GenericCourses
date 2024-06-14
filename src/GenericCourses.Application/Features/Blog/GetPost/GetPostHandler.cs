using MediatR;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Blog;

public class GetPostHander : IRequestHandler<GetPostRequest, BlogPost> {

	private readonly IPostRepository _postRepository;

	public GetPostHander(IPostRepository postRepository) => _postRepository = postRepository;

	public async Task<BlogPost> Handle(GetPostRequest request, CancellationToken ct) {

		return await _postRepository.single(request.id);

	}
}
