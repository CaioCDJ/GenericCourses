using MediatR;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using GenericCourses.Infra.Repositories;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Subscriptions;

public class StoreSubscriptionHandler : IRequestHandler<StoreSubscriptionRequest, Subscriptionplan> {

	private readonly ISubscriptionPlanRepository _subscriptionPlanRepository;

	private readonly AppDbContext _appDbContext;

	public StoreSubscriptionHandler(ISubscriptionPlanRepository subscriptionPlanRepository, AppDbContext appDbContext) {
		_subscriptionPlanRepository = subscriptionPlanRepository;
		_appDbContext = appDbContext;
	}

	public async Task<Subscriptionplan> Handle(StoreSubscriptionRequest request, CancellationToken ct) {

		var admin = await _appDbContext.admins.SingleOrDefaultAsync(x => x.userId == request.admin_id);

		if (admin is null) { }

		var new_subs = await _subscriptionPlanRepository.store(new Subscriptionplan() {
			price = request.price,
			description = request.description,
			months = request.months,
			adminId = admin.id
		});

		return new_subs;
	}
}

