using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using Dapper;
using Npgsql;

namespace GenericCourses.Infra.Repositories;

public class AuthRepository : IAuthRepository {

	private readonly AppDbContext _context;

	public AuthRepository(AppDbContext context) {
		_context = context;
	}

	public async Task<bool> canRegister(User user) {
		return false;
	}

	public async Task<User> register(User user) {
		_context.users.Add(user);
		await _context.SaveChangesAsync();
		return user;
	}

	public async Task<User> canLogin(string email, string password) {
		return new User();
	}

}
