using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Enums;

namespace GenericCourses.Infra.Repositories;

public interface IAuthRepository {
	Task<bool> canRegister(User user);
	Task<Client?> register(User user);
	Task<User?> canLogin(string email);
	Task<UserRole?> get_role(Guid user_id);
}
