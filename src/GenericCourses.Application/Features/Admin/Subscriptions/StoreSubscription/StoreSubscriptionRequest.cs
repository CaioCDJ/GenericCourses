using MediatR;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Admin.Subscriptions;

public record StoreSubscriptionRequest(
	float price, string description, int months, Guid admin_id
) : IRequest<Subscriptionplan>;


