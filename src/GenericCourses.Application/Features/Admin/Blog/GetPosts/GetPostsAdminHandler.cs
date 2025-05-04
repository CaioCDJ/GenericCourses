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

		int offset = (request.pageSize > 1)
		  ? (request.pageSize * (request.pageIndex - 1)) : 0;
		
		var lst = await _postRepository.paginateAdmin(offset,request.pageSize);
		
		var qt = (request.userId.HasValue)
			? await _postRepository.QtByUsers(request.userId.Value)
			: await _postRepository.count();

		return new PaginatedList<GetPostAdminQuery>(
			lst, qt.Value, request.pageIndex, 10
		  );
	}
}
