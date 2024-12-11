using GenericCourses.Application.Common;
using GenericCourses.Domain.Dtos.Pages;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Persistence;

using MediatR;

namespace GenericCourses.Application.Features.Blog;

public class GetPostsHandler : IRequestHandler<GetPostsRequest, GetPostsResponse> {
	private readonly IPostRepository _postRepository;
	private readonly ICategoriesRepository _categoriesRepository;
	private readonly AppDbContext _context;

	public GetPostsHandler(IPostRepository postRepository, AppDbContext context, ICategoriesRepository categoriesRepository) {
		_postRepository = postRepository;
		_categoriesRepository = categoriesRepository;
		_context = context;
	}

	public async Task<GetPostsResponse> Handle(GetPostsRequest request, CancellationToken cancellationToken) {

		var index = (request.pageIndex > 1) ? request.pageIndex : 1;

		int offset = (index > 1)
		  ? (request.pageSize * index) : 0;

		var lst = await _postRepository.paginate(
		  offset,
		  request.pageSize,
		  request.categories,
		  request.searchParam
		);

		var categories = await _categoriesRepository.getAll();
		// string[] categories = ["oliver","oliver 2"];
		
		var pagination = new PaginatedList<PostDTO>(
		  lst, _context.blog_posts.Count(), 4, 0
		);

		return new GetPostsResponse(pagination, categories);
	}
}
