using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Infra.Repositories;


internal abstract class Repository<T> where T : Entity {

	protected readonly AppDbContext _context;

	protected Repository(AppDbContext appDbContext)
		=> _context = appDbContext;

	public async Task<T?> single(Guid id)
		=> await _context.Set<T>().SingleOrDefaultAsync(x => x.id == id);

	public async Task<int?> count()
		=> await _context.Set<T>().CountAsync();

	public async Task<T> store(T entity) {
		await _context.Set<T>().AddAsync(entity);
		await _context.SaveChangesAsync();
		return entity;
	}

	public async Task<T> update(T entity) {
		_context.Set<T>().Update(entity);
		await _context.SaveChangesAsync();
		return entity;
	}

	public async Task<T> remove(T entity) {
		_context.Set<T>().Remove(entity);
		await _context.SaveChangesAsync();
		return entity;
	}


}
