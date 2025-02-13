using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using GenericCourses.Infra.Repositories.Queries;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Dapper;

namespace GenericCourses.Infra.Repositories;

internal sealed class SubscriptionPlanRepository : Repository<Subscriptionplan>, ISubscriptionPlanRepository {

	private readonly string _connString;

	public SubscriptionPlanRepository(AppDbContext context) : base(context) {
		_connString = context.Database.GetConnectionString();
	}

	public async Task<Subscriptionplan?> findOne(Guid id)
		=> await _context.subscription_plans.FirstOrDefaultAsync(x => x.id == id);

	public async Task<Subscriptionplan?> findFree()
		=> await _context.subscription_plans.FirstOrDefaultAsync(x => x.price == 0);

	public async Task<List<GetSubscriptionsQuery>> paginate(int offfset) {
		using var conn = new NpgsqlConnection(_connString);

		await conn.OpenAsync();

		var lst = await conn.QueryAsync<GetSubscriptionsQuery>(@$"
			SELECT *, (SELECT COUNT(*) FROM clients AS c WHERE c.subscriptionplanid = sp.id ) AS clients 
				FROM subscription_plans AS sp;
				", new { offfset });

		await conn.CloseAsync();

		return lst.ToList();
	}

	public async Task<Client> sign(Client client) {
		await _context.clients.AddAsync(client);
		await _context.SaveChangesAsync();
		return client;
	}

}
