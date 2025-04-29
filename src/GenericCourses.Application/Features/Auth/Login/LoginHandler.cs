using MediatR;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Security;
using GenericCourses.Domain.Enums;

namespace GenericCourses.Application.Features.Auth;

public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse> {

	private IAuthRepository _IauthRepository;

	public LoginHandler(IAuthRepository authRepository)
		=> _IauthRepository = authRepository;

	public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken ct) {

		var password_hash = Hasing.hash(request.password);
		var user = await _IauthRepository.canLogin(request.email);

		if (user is null) { }

		if (!Hasing.verify(request.password, user.password)) {

		}

		var role = await _IauthRepository.get_role(user.id);

		if (!role.HasValue) { }

		return new LoginResponse(
			user.id, user.name, role.GetValueOrDefault()
		);
	}
}
