using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Persistence;
using GenericCourses.Infra.Repositories.Queries;
using MediatR;

namespace GenericCourses.Application.Features.Admin.Blog;

public class GetPostsAdminHandler : IRequestHandler<GetPostsAdminRequest, PaginatedList<GetPostAdminQuery>> {

	private readonly IPostRepository _postRepository;

	public GetPostsAdminHandler(IPostRepository postRepository) {
		_postRepository = postRepository;
	}

	public async Task<PaginatedList<GetPostAdminQuery>> Handle(GetPostsAdminRequest request, CancellationToken ct) {
		var lst = await _postRepository.paginateAdmin(request.userId, request.pageSize);
		var qt = await _postRepository.QtByUsers(request.userId);

		return new PaginatedList<GetPostAdminQuery>(
			lst, qt, request.pageIndex
		  );

	}
}
