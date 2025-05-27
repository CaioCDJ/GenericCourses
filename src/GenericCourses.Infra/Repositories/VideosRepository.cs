
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GenericCourses.Infra.Repositories;

internal sealed class VideosRepository : Repository<Video>, IVideosRepository {

	public VideosRepository(AppDbContext context) : base(context) { }

	public async Task<Video?> single(Guid id)
		=> await _context.videos.SingleOrDefaultAsync(item => item.id == id);

	public async Task<List<Video>> paginate(Guid module_id, int page = 1)
		=> await _context.videos.Where(x => x.moduleId == module_id)
			.Skip((page == 1) ? 0 : page * 10)
			.Take(10)
			.OrderBy(x => x.order)
			.ToListAsync();
}
