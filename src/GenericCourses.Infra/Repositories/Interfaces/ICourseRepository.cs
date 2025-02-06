using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Infra.Repositories;

public interface ICourseRepository {
	Task<Course?> single(Guid id);
	Task<List<GetCourseAdminQuery>> paginateAdmin(int size = 10, int offset = 0);
	Task<int> count();
	Task<Course> store(Course course);
	Task<Course> update( Course course);
	Task<Course> remove(Course course);
}
