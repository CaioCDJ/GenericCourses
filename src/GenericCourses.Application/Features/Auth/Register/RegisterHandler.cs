using MediatR;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Security;
using GenericCourses.Infra.Repositories;
using GenericCourses.Application.Common;

namespace GenericCourses.Application.Features.Auth;

public class RegisterHandler : IRequestHandler<RegisterRequest, Result<User,Error>> {

	private readonly IAuthRepository _authRepository;
	private readonly ISubscriptionPlanRepository _subscriptionPlanRepository;

	public RegisterHandler(IAuthRepository authRepository, ISubscriptionPlanRepository subscriptionPlanRepository) {
		_authRepository = authRepository;
		_subscriptionPlanRepository = subscriptionPlanRepository;
	}

	public async Task<Result<User,Error>> Handle(RegisterRequest request, CancellationToken ct) {
		var user = new User() {
			name = request.name,
			email = request.email,
			password = Hasing.hash(request.password),
			phone = double.Parse(request.phone),
			cpf = double.Parse(request.cpf),
		};

		if (!await _authRepository.canRegister(user)) {
			return new Error("400", "Erro ao cadastrar o usuario");	
		}

		var client = await _authRepository.register(user);

		var freePlan = await _subscriptionPlanRepository.findFree();

		await _subscriptionPlanRepository.sign(client, freePlan.id);

		return  user;
	}
}
