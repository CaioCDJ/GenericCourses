using GenericCourses.Domain.Entities;

namespace GenericCourses.Infra.Repositories;


public interface ICategoriesRepository {
	Task<string[]?> getAll();
}
