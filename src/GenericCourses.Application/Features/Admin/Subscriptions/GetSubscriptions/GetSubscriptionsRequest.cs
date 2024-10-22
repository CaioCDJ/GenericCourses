using MediatR;
using GenericCourses.Domain.Entities;
using GenericCourses.Application.Common;
using GenericCourses.Infra.Repositories.Queries;

namespace GenericCourses.Application.Features.Admin.Subscriptions;

public record GetSubcriptionRequest(
	int page
) : IRequest<PaginatedList<GetSubscriptionsQuery>>;
