using MediatR;
using GenericCourses.Domain.Entities;
using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Application.Features.Admin.Subscriptions;

public class GetSubscriptionsHandler : IRequestHandler<GetSubcriptionRequest, PaginatedList<GetSubscriptionsQuery>> {

	private readonly ISubscriptionPlanRepository _subscriptionPlanRepository;

	public GetSubscriptionsHandler(ISubscriptionPlanRepository repository)
		=> _subscriptionPlanRepository = repository;

	public async Task<PaginatedList<GetSubscriptionsQuery>> Handle(GetSubcriptionRequest request, CancellationToken cancellationToken) {

		var lst = await _subscriptionPlanRepository.paginate(
			request.page >= 1 ? (request.page - 1) * 10 : 0
		);

		var qt = await _subscriptionPlanRepository.count();

		return new PaginatedList<GetSubscriptionsQuery>(
			lst, (qt.HasValue ? qt.Value : 0), request.page, 10
		);
	}
}
