using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos.Pages;

namespace GenericCourses.Infra.Repositories;

public interface IInstructorRepository {

	Task<AdminAccountDTO> accountInfo(Guid id);
	Task<Instructor?>single(Guid id);
	Task<int?> count();
	Task<Instructor> store(Instructor instructor);
	Task<Instructor> update(Instructor instructor);
	Task<Instructor> remove(Instructor instructor);
}
