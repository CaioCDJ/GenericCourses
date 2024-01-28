using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos.Forms;

namespace GenericCourses.Domain.Contracts.Repositories;

public interface IPostReepsitory
{
    Task<Post> single(Guid id);
    Task<List<Post>> paginate(int page, int size = 10);
    Task<Post> store(Post post);
    Task<Post> update(Post post);
    Task<Post> remove(Guid id);
}
