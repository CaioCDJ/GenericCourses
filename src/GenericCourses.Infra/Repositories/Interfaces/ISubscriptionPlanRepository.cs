using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories.Queries;
namespace GenericCourses.Infra.Repositories;

public interface ISubscriptionPlanRepository {
	Task<Subscriptionplan?> findOne(Guid id);
	Task<Subscriptionplan?> findFree();
	Task<List<GetSubscriptionsQuery>> paginate(int offfset);
	Task<Client?> sign(Client client, Guid plan_id);
	Task<int?> count();
	Task<Subscriptionplan> store(Subscriptionplan plan);
	Task<Subscriptionplan> update(Subscriptionplan plan);
	Task<Subscriptionplan> remove(Subscriptionplan plan);
}
