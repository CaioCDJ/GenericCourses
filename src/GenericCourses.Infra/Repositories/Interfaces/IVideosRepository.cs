using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Infra.Repositories;

public interface IVideosRepository {
	Task<List<Video>> paginate(Guid module_id, int page);
	Task<Video> store(Video video);
	Task<Video> update(Video video);
	Task<Video> remove(Video video);
}

