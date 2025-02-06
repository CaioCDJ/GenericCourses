using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos;
using GenericCourses.Infra.Repositories.Queries;
using Dapper;
using Npgsql;

namespace GenericCourses.Infra.Repositories;

internal sealed class ModulesRepository : Repository<Module>, IModulesRepository {
	private readonly string _connString;

	public ModulesRepository(AppDbContext context):base(context) {
		_connString = context.Database.GetConnectionString();
	}

	public async Task<Module> single(Guid id)
		=> await _context.modules.SingleOrDefaultAsync(item => item.id == id);


	public async Task<List<ModulesByCourseQuery>> paginate(Guid course_id, int? page) {

		using var conn = new NpgsqlConnection(_connString);

		await conn.OpenAsync();

		int offset = page == null ? 0 : (int) page * 10;

		string query = @$"
			SELECT id,title,complete 
				FROM modules AS m 
					ORDER BY m.order
					LIMIT 10
					OFFSET @offset
		";

		var lst = await conn.QueryAsync<ModulesByCourseQuery>(
				query, new { offset = offset, course_id = course_id });

		await conn.CloseAsync();

		return lst.ToList();
	}

	public async Task<List<QtModulesByCourseQuery>> countByCourse(Guid[] ids) {
		using var conn = new NpgsqlConnection(_connString);

		string where = "(";

		foreach (var id in ids) {
			where += $"'{id}',";
		}

		where = where.Remove(where.Length - 1) + ")";

		await conn.OpenAsync();

		string query = @$"
			SELECT COUNT(m.id), m.course_id as id FROM modules AS m
				WHERE m.course_id IN {where}
					GROUP BY m.course_id; 
		";

		var lst = await conn.QueryAsync<QtModulesByCourseQuery>(query);

		await conn.CloseAsync();

		return lst.ToList();
	}

}
