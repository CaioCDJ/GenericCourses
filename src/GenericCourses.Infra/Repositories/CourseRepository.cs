using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using GenericCourses.Infra.Repositories.Queries;
using Dapper;
using Npgsql;

namespace GenericCourses.Infra.Repositories;

internal sealed class CourseRepository : Repository<Course>, ICourseRepository {
	private readonly string _connString;

	public CourseRepository(AppDbContext context) : base(context) {
		_connString = context.Database.GetConnectionString();
	}

	public async Task<List<Course>> paginate(int page = 1)
		=> await _context.courses
			.Include(x => x.courseCategories)
			.Skip((page == 1) ? 0 : page * 10)
			.Take(10)
			.ToListAsync();

	public async Task<Course?> single(Guid id)
	  => await _context.courses
			.Include(x => x.modules.OrderBy(x => x.order))
			.ThenInclude(x => x.videos.OrderBy(x => x.order))
			.Include(x => x.courseCategories)
			.Include(x => x.instructor)
			.ThenInclude(x => x.user)
			.SingleOrDefaultAsync(x => x.id == id);


	public async Task<List<GetCourseAdminQuery>> paginateAdmin(int size = 10, int offset = 0) {

		using var conn = new NpgsqlConnection(_connString);

		string query = @"
			SELECT c.id, c.title, c.is_free, c.active, c.created_at, c.lastupdate, u.name FROM courses AS c 
				JOIN instructors AS i ON i.id = c.instructor_id 	
				JOIN users AS u ON u.id  = i.user_id 
				LIMIT @size
				OFFSET @offset
		";

		await conn.OpenAsync();

		var lst = await conn.QueryAsync<GetCourseAdminQuery>(query, new {
			size = size,
			offset = offset
		});

		await conn.CloseAsync();

		return lst.ToList();
	}

}
