using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos.Forms;
using GenericCourses.Domain.Dtos.Pages;

namespace GenericCourses.Infra.Repositories;

public interface IPostRepository
{
    Task<BlogPost> single(Guid id);
    Task<List<PostDTO>> paginate(int offset, int size=8);
    Task<BlogPost> store(BlogPost post);
    Task<BlogPost> update(BlogPost post);
    Task<BlogPost> remove(Guid id);
}
