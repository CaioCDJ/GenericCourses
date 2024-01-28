using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos.Forms;

namespace GenericCourses.Domain.Contracts.Repositories;

public interface IPostReepsitory
{
    Task<BlogPost> single(Guid id);
    Task<BlogPost> store(BlogPost post);
    Task<BlogPost> update(BlogPost post);

    Task<BlogPost> remove(Guid id);
}
