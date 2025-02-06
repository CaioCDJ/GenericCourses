using GenericCourses.Domain.Entities;

namespace GenericCourses.Infra.Repositories;


public interface ICategoriesRepository {
	Task<string[]?> getAll();
	Task<Category> store(Category category);
	Task<Category> update(Category category);
	Task<Category> remove(Category category);
}
