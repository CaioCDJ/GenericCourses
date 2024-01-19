using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos.Forms;

namespace GenericCourses.Domain.Contracts.Repositories;

public interface IPostReepsitory
{

    Task<Post> single(Guid id);
    Task<Post> store(Post post);
    Task<Post> remove(Guid id);
}
