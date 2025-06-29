using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Dapper;

namespace GenericCourses.Infra.Repositories;

public record Current_progress_query {
	public string module_name { get; set; }
	public bool module_done { get; set; }
	public string video_title { get; set; }
	public Guid video_id { get; set; }
	public int order { get; set; }
	public bool watched { get; set; }
	public string video_url { get; set; }
};

public interface ICourseProgressRepository : IRepository<CourseProgress> {
	Task<CourseProgress?> exists(Guid course_id, Guid user_id);
	Task<IEnumerable<Current_progress_query>> current_progress(Guid user_id, Guid course_id);
}

internal sealed class CourseProgressRepository : Repository<CourseProgress>, ICourseProgressRepository {
	public CourseProgressRepository(AppDbContext context) : base(context) { }

	public async Task<CourseProgress?> single(Guid id)
		=> await _context.course_Progresses.SingleOrDefaultAsync(x => x.id == id);

	public async Task<CourseProgress?> exists(Guid course_id, Guid user_id)
		=> await _context.course_Progresses.SingleOrDefaultAsync(
			x => x.userId == user_id && x.courseId == course_id
		);
	
	public async Task<IEnumerable<Current_progress_query>> current_progress(Guid user_id, Guid course_id){
		using var conn = new NpgsqlConnection(_context.Database.GetConnectionString());
		var res = await conn.QueryAsync<Current_progress_query>(@"
			SELECT m.title AS module_name,v.""order"", mp.done AS module_done, 
			v.title AS video_title, v.id AS video_id, vp.done AS watched,v.video_url 
				FROM courses AS co
					JOIN course_progresses cp ON cp.course_id  = co.id 
						AND co.id = @course_id AND cp.user_id = @user_id
					LEFT JOIN modules_progress AS mp ON mp.course_progress_id = cp.id
 					LEFT JOIN video_progresses AS vp ON vp.module_id = mp.id
 					RIGHT JOIN modules m ON m.course_id = co.id 
 					RIGHT JOIN videos v ON v.module_id = m.id
						ORDER BY m.""order"", v.""order""
		", new {course_id = course_id, user_id = user_id});
		
		return res;
	}
}
