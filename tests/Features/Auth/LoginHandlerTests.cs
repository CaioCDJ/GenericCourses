using Xunit.Abstractions;
using GenericCourses.Application.Features.Auth;
using GenericCourses.Infra.Repositories;
using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Enums;
using NSubstitute;
using Bogus;

public class LoginHandlerTests {

	private IAuthRepository _authRepository;

	private readonly User _fake_user;

	public LoginHandlerTests() {
		_authRepository = Substitute.For<IAuthRepository>();
		_fake_user = new Faker<User>("pt_BR")
			.RuleFor(u => u.name, f => f.Person.UserName)
			.RuleFor(u => u.email, f => f.Person.Email)
			.RuleFor(u => u.password, f => f.Person.Email)
			.RuleFor(u => u.cpf, f => f.Random.Int())
			.RuleFor(u => u.is_active, true)
			.Generate();
	}

	[Fact]
	public async Task good_ending() {

		// arrange
		var request = new LoginRequest(
			"email@email.com", "senha123"
		);

		_authRepository.canLogin(request.email).Returns(_fake_user);

		_authRepository.get_role(_fake_user.id).Returns(UserRole.client);

		var handler = new LoginHandler(_authRepository);

		// act
		var response = await handler.Handle(request, CancellationToken.None);

		// assert
		Assert.NotNull(response.name);
	}

}
