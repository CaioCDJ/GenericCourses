using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories.Queries;
namespace GenericCourses.Infra.Repositories;

public interface ISubscriptionPlanRepository {
	Task<Subscriptionplan> findOne(Guid id);
	Task<Subscriptionplan> findFree();
	Task<List<GetSubscriptionsQuery>> paginate(int offfset);
	Task<int> count();
	Task<Subscriptionplan> store(Subscriptionplan subscriptionplan);
	Task<Subscriptionplan> update(Subscriptionplan subscriptionplan);
	Task<bool> remove(Subscriptionplan subscriptionplan);
	Task<Client> sign(Client client);
}
