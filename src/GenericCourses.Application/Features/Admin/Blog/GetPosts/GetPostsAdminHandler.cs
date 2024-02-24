using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Dtos.Querys;
using MediatR;

namespace GenericCourses.Application.Features.Admin.Blog;

public class GetPostsAdminHandler : IRequestHandler<GetPostsAdminRequest, PaginatedList<GetPostAdminQuery>>
{

  private readonly PostRepository _postRepository;
  private readonly AppDbContext _context;

  public GetPostsAdminHandler(PostRepository postRepository, AppDbContext context)
  {
    _postRepository = postRepository; _context = context;
  }

  public async Task<PaginatedList<GetPostAdminQuery>> Handle(GetPostsAdminRequest request, CancellationToken ct)
  {
    var lst = await _postRepository.paginateAdmin(request.userId, request.pageSize);
    var qt = await _postRepository.QtByUsers(request.userId);
    
    return new PaginatedList<GetPostAdminQuery>(
        lst, qt, request.pageIndex
      );

  }
}
