using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos.Pages;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Infra.Repositories;

public interface IPostRepository {
	Task<BlogPost> single(Guid id);
	Task<List<PostDTO>> paginate(int offset, int size = 8, string[]? categories = null,
			string? searchParam=null);
	Task<List<GetPostAdminQuery>> paginateAdmin(Guid id, int offset, int size = 8);
	Task<int> QtByUsers(Guid id);
	Task<BlogPost> store(BlogPost post);
	Task<BlogPost> update(BlogPost post);
	Task<BlogPost> remove(Guid id);
}
