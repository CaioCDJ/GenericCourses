using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Enums;
using Dapper;
using Npgsql;
using Microsoft.EntityFrameworkCore;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Infra.Repositories;

public class AuthRepository : IAuthRepository {

	private readonly AppDbContext _context;

	public AuthRepository(AppDbContext context) {
		_context = context;
	}

	public async Task<bool> canRegister(User user) =>
		await _context.users.SingleOrDefaultAsync(
			x => x.email == user.email || x.cpf == user.cpf
		) is null;

	public async Task<Client?> register(User user) {
		_context.users.Add(user);
		_context.clients.Add(new Client() {
			userId = user.id,
		});

		await _context.SaveChangesAsync();
		return await _context.clients.SingleOrDefaultAsync(x => x.userId == user.id);
	}

	public async Task<User?> canLogin(string email)
		=> await _context.users.SingleOrDefaultAsync(
			x => x.email == email);

	public async Task<UserRole?> get_role(Guid user_id) {
		using var conn = new NpgsqlConnection(_context.Database.GetConnectionString());

		UserRole? res = null;

		var response = await conn.QueryFirstAsync<GetUserRoleQuery>(@"
			SELECT c.id AS client_id, a.id AS admin_id, i.id AS instructor_id FROM users AS u
				LEFT JOIN clients c ON c.user_id = u.id 
				LEFT JOIN admins a ON a.user_id  =u.id	
				LEFT JOIN instructors i ON i.user_id = u.id
					WHERE u.id = @user_id;
			", new { user_id }
		);

		conn.Close();

		if (response.client_id is not null && response.instructor_id is null && response.admin_id is null)
			res = UserRole.client;
		else if (response.client_id is null && response.instructor_id is not null && response.admin_id is null)
			res = UserRole.instructor;
		else if (response.client_id is null && response.instructor_id is null && response.admin_id is not null)
			res = UserRole.admin;

		return res ?? null;
	}
}
