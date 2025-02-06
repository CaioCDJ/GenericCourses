using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Dapper;

namespace GenericCourses.Infra.Repositories;

internal sealed class CategoriesRepository :Repository<Category>, ICategoriesRepository {

	private readonly string _conString;

	public CategoriesRepository(AppDbContext context):base(context) {
		_conString = context.Database.GetConnectionString();
	}

	public async Task<string[]?> getAll() {
		var conn = new NpgsqlConnection(_conString);
		await conn.OpenAsync();
		var query = "SELECT name FROM categories ORDER BY name";

		var lst = await conn.QueryAsync<string>(query);

		await conn.CloseAsync();

		return lst.ToArray() ?? [];
	}
}
