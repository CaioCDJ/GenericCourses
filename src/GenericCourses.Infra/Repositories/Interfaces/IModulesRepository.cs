using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Infra.Repositories;

public interface IModulesRepository {
	Task<Module> single(Guid id);
	Task<List<ModulesByCourseQuery>> paginate(Guid course_id, int? page);

	Task<List<QtModulesByCourseQuery>> countByCourse(Guid[] ids);
	Task<Module> store(Module module);
	Task<Module> update(Module module);
	Task<Module> remove(Module module);
}

