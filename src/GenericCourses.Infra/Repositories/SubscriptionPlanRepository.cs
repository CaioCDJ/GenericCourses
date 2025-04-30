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

	public async Task<List<GetSubscriptionsQuery>> paginate(int offset) {
		using var conn = new NpgsqlConnection(_connString);

		await conn.OpenAsync();

		var lst = await conn.QueryAsync<GetSubscriptionsQuery>(@$"
			SELECT *, (SELECT COUNT(*) FROM clients AS c WHERE c.subscriptionplanid = sp.id ) AS clients 
				FROM subscription_plans AS sp
                ORDER BY price
				LIMIT 10
                OFFSET @offset
				;
				", new { offset = offset });

		await conn.CloseAsync();

		return lst.ToList();
	}

	public async Task<Client?> sign(Client client, Guid plan_id) {
		var plan = await _context.subscription_plans.SingleOrDefaultAsync(x => x.id == plan_id);

		if (plan is null) return null;

		_context.user_plan.Add(new User_Plan() {
			client = client,
			subscriptionplanId = plan_id
		});
		_context.Update<Subscriptionplan>(plan);
		await _context.SaveChangesAsync();
		return client;
	}
}
