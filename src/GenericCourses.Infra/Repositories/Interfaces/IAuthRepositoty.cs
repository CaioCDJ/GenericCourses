using GenericCourses.Domain.Entities;

namespace GenericCourses.Infra.Repositories;

public interface IAuthRepository {
	Task<bool> canRegister(User user);
	Task<User> register(User user);
	Task<User> canLogin(string email, string password);
}
