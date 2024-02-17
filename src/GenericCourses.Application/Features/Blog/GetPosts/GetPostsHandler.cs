using GenericCourses.Application.Common;
using GenericCourses.Domain.Dtos.Pages;
using MediatR;

namespace GenericCourses.Application.Features.Blog;

public class GetPostsHandler : IRequestHandler<GetPostsRequest,PaginatedLista<PostDTO>>
{
  public async Task<PaginatedLista<PostDTO>> Handle(GetPostsRequest requests, CancellationToken ct){

    var a =new List<PostDTO>();
    return new PaginatedLista<PostDTO>(a,2,4,0);
  }
}
