using GenericCourses.Domain.Entities;

namespace GenericCourses.Infra.Repositories;

public interface IClientRepository {
	Task<User?> single(Guid client_id);
	Task<bool> update_progress(Guid client_id, Guid video_id);
}
