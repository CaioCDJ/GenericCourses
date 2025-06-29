using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Dapper;

namespace GenericCourses.Infra.Repositories;

public interface IModuleProgressRepository {
	Task<ModuleProgress?> single(Guid id);
	Task<ModuleProgress> store(ModuleProgress video);
	Task<ModuleProgress> update(ModuleProgress video);
	Task<ModuleProgress> remove(ModuleProgress video);
}

internal sealed class ModuleProgressRepository : Repository<ModuleProgress>, IModuleProgressRepository {

	public ModuleProgressRepository(AppDbContext context) : base(context) { }

	public async Task<ModuleProgress?> single(Guid id)
		=> await _context.modules_progress.SingleOrDefaultAsync(x => x.id == id);
}
