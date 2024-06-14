using MediatR;
using GenericCourses.Domain.Entities;
using MediatR;
using GenericCourses.Infra.Security;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Application.Features.Auth;

public class RegisterHandler : IRequestHandler<RegisterRequest, User> {

	private readonly IAuthRepository _authRepository;
	private readonly ISubscriptionPlanRepository _subscriptionPlanRepository;

	public RegisterHandler(IAuthRepository authRepository, ISubscriptionPlanRepository subscriptionPlanRepository) {
		_authRepository = authRepository;
		_subscriptionPlanRepository = subscriptionPlanRepository;
	}

	public async Task<User> Handle(RegisterRequest request, CancellationToken ct) {

		var user = new User() {
			name = request.name,
			email = request.email,
			password = Hasing.hash(request.password),
			phone = double.Parse(request.phone),
			cpf = double.Parse(request.cpf),
		};

		await _authRepository.canRegister(user);

		var freePlan = await _subscriptionPlanRepository.findFree();

		await _subscriptionPlanRepository.sign(new Client() {
			userId = user.id,
			subscriptionplanId = freePlan.id
		});

		return user;
	}
}
