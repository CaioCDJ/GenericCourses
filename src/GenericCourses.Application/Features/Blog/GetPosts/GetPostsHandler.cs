using GenericCourses.Application.Common;
using GenericCourses.Domain.Dtos.Pages;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Persistence;

using MediatR;

namespace GenericCourses.Application.Features.Blog;

public class GetPostsHandler : IRequestHandler<GetPostsRequest, PaginatedList<PostDTO>>
{
    private readonly PostRepository _postRepository;
    private readonly AppDbContext _context;

    public GetPostsHandler(PostRepository postRepository, AppDbContext context)
    {
        _postRepository = postRepository;
        _context = context;
    }

    public async Task<PaginatedList<PostDTO>> Handle(GetPostsRequest requests, CancellationToken ct)
    {
        var index = (requests.pageIndex > 1) ? requests.pageIndex : 1;

        int offset = (index > 1)
          ? (requests.pageSize * index) : 0;

        var lst = await _postRepository.paginate(offset);

        // for (int i = 0; i <= lst.Count; i++)
        // lst[i].postId = Convert.ToBase64String(      elst[i].postId);

        return new PaginatedList<PostDTO>(
          lst, _context.blog_posts.Count(), 4, 0
        );
    }
}
