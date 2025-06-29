namespace GenericCourses.Infra.Repositories;

public interface IRepository<T> where T : class {
	Task<T?> single(Guid id);
	Task<T> update(T entity);
	Task<T> store(T entity);
	Task<T> remove(T entity);
}
