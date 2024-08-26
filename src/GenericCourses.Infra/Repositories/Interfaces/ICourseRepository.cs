using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos;

namespace GenericCourses.Infra.Repositories;

public interface ICourseRepository {
	Task<Course> single(Guid id);
	Task<Course> store(Course course);
	Task<Course> update(Guid id, Course course);
	Task delete(Guid id);
}
