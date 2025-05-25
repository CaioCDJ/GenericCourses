using FluentValidation;
using GenericCourses.Application.Features.Auth;

namespace GenericCourses.Web.Validations;

public class LoginRequestValidator : AbstractValidator<LoginRequest> {

	public LoginRequestValidator() {
		RuleFor(x => x.email)
			.EmailAddress().WithMessage("E-mail invalido!")
			.NotEmpty().WithMessage("E-mail é mandatorio!");
		RuleFor(x => x.password)
			.NotEmpty().WithMessage("A senha é mandatoria!")
			.MinimumLength(7).WithMessage("A senha deve ter no minimo 7 caracteres");
	}
}
