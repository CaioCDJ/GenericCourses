using GenericCourses.Domain.Entities;
namespace GenericCourses.Infra.Repositories;

public interface ISubscriptionPlanRepository {
	Task<Subscriptionplan> findOne(Guid id);
	Task<Subscriptionplan> findFree();
	Task<Subscriptionplan> store(Subscriptionplan subscriptionplan);
	Task<Subscriptionplan> update(Subscriptionplan subscriptionplan);
	Task<bool> remove(Subscriptionplan subscriptionplan);
	Task<Client> sign(Client client);
}
