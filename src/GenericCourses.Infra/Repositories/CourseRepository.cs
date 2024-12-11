using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using GenericCourses.Infra.Repositories.Queries;
using Dapper;
using Npgsql;

namespace GenericCourses.Infra.Repositories;

public class CourseRepository : ICourseRepository {
	private readonly AppDbContext _context;
	private readonly string _connString;

	public CourseRepository(AppDbContext context) {
		_context = context;
		_connString = context.Database.GetConnectionString();
	}

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

	public async Task<int> count()
		=> await _context.courses.CountAsync();

	public async Task<Course> store(Course course) {
		var check = await _context.courses.FirstOrDefaultAsync(x =>
			x.title == course.title);

		if (check is not null) throw new Exception(message: $"Já existe um curso com o nome: {course.title}");

		await _context.courses.AddAsync(course);
		await _context.SaveChangesAsync();
		return course;
	}

	public async Task<Course> update(Guid id, Course course) {
		var courseCheck = await this.single(id);

		if (courseCheck is null) throw new Exception(message: $"O usuario não foi encontrado!");

		_context.courses.Update(course);
		await _context.SaveChangesAsync();

		return course;
	}

	public async Task delete(Guid id) {
		var course = await _context.courses.FirstOrDefaultAsync(x => x.id == id);

		if (course is null) throw new Exception(message: $"O Curso não foi encontrado!");

		_context.courses.Remove(course);

		await _context.SaveChangesAsync();
	}
}
