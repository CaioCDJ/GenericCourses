using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GenericCourses.Infra.Repositories;

public class SubscriptionPlanRepository : ISubscriptionPlanRepository {

	private readonly AppDbContext _context;

	public SubscriptionPlanRepository(AppDbContext context) {
		_context = context;
	}

	public async Task<Subscriptionplan> findOne(Guid id)
		=> await _context.subscription_plans.FirstOrDefaultAsync(x => x.id == id);

	public async Task<Subscriptionplan> findFree()
		=> await _context.subscription_plans.FirstOrDefaultAsync(x => x.price == 0);

	public async Task<Subscriptionplan> store(Subscriptionplan plan) {
		await _context.subscription_plans.AddAsync(plan);
		await _context.SaveChangesAsync();
		return plan;
	}

	public async Task<Subscriptionplan> update(Subscriptionplan plan) {
		_context.Update(plan);
		await _context.SaveChangesAsync();
		return plan;
	}

	public async Task<bool> remove(Subscriptionplan subscriptionplan) {
		_context.subscription_plans.Remove(subscriptionplan);
		await _context.SaveChangesAsync();
		return true;
	}

	public async Task<Client> sign(Client client) {
		await _context.clients.AddAsync(client);
		await _context.SaveChangesAsync();
		return client;
	}
}
