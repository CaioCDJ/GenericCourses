using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Dapper;

namespace GenericCourses.Infra.Repositories;

public interface IVideoProgrssRepository {
	Task<VideoProgress?> single(Guid id);
	Task<VideoProgress> store(VideoProgress video);
	Task<VideoProgress> update(VideoProgress video);
	Task<VideoProgress> remove(VideoProgress video);
}

internal sealed class VideoProgrssRepository : Repository<VideoProgress>, IVideoProgrssRepository {
	public VideoProgrssRepository(AppDbContext context) : base(context) { }

	public async Task<VideoProgress?> single(Guid id)
		=> await _context.video_progresses.SingleOrDefaultAsync(x => x.id == id);
}
