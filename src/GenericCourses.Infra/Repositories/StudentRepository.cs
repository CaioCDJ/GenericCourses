using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Dapper;

namespace GenericCourses.Infra.Repositories;

public record full_course_query(
	string title,
	string module_id,
	bool m_done,
	string video_title,
	string video_id,
	bool video_done
);

public interface IStudentRepository : IRepository<Client> {
	Task<Client?>SingleByUserId(Guid id);
	Task<List<full_course_query>> full();
}

internal sealed class StudentRepository : Repository<Client>, IStudentRepository {

	public StudentRepository(AppDbContext context) : base(context) { }

	public async Task<Client?> single(Guid id)
		=> await _context.clients.SingleOrDefaultAsync(z => z.id == id);

	public async Task<Client?> SingleByUserId(Guid id)
		=> await _context.clients.SingleOrDefaultAsync(z => z.userId == id);

	public async Task<List<full_course_query>> full() {
		using var conn = new NpgsqlConnection(_context.Database.GetConnectionString());
		var query_response = await conn.QueryAsync<full_course_query>(@"
			select co.title, m.id as module_id , mp.done as m_done, 
				v.title as video_title, v.id as video_id,vp.done as video_done
				from courses as co
				join course_progresses cp on cp.id = co.id
				join modules_progress as mp on mp.course_progress_id = cp.id
 				join video_progresses as vp on vp.module_id = mp.id
 				left join modules m on m.course_id = co.id and mp.module_id = m.id
 				left join videos v on v.module_id = m.id and v.id = vp.video_id
 				order by m.""order"" , v.""order""
		");
		return query_response.ToList();
	}
}
