using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos.Pages;

namespace GenericCourses.Infra.Repositories;

public interface IInstructorRepository {

	Task<AdminAccountDTO> accountInfo(Guid id);

}
