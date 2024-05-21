using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;

namespace GenericCourses.Infra.Repositories;

public interface IAuthRepository {
	Task<bool> canRegister();
	Task<User> register();
	// Task<LoginRequest>();
}
