using MediatR;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Security;
using GenericCourses.Domain.Enums;
using GenericCourses.Application.Common;

namespace GenericCourses.Application.Features.Auth;

public class LoginHandler : IRequestHandler<LoginRequest, Result<LoginResponse, Error>> {

	private IAuthRepository _IauthRepository;

	public LoginHandler(IAuthRepository authRepository)
		=> _IauthRepository = authRepository;

	public async Task<Result<LoginResponse, Error>> Handle(LoginRequest request, CancellationToken ct) {

		var password_hash = Hasing.hash(request.password);
		var user = await _IauthRepository.canLogin(request.email);

		if (user is null) {
			return new Error("400", "Usuario não encontrado!");
		}

		if (!Hasing.verify(request.password, user.password)) {
			return new Error("400", "Erro ao realizar o login");
		}

		var role = await _IauthRepository.get_role(user.id);

		if (!role.HasValue) { }

		return new LoginResponse(
			user.id, user.name, role.GetValueOrDefault()
		);
	}
}
