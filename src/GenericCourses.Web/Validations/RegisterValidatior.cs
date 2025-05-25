using FluentValidation;
using GenericCourses.Application.Features.Auth;

namespace GenericCourses.Web.Validations;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest> {

	public RegisterRequestValidator() {
		RuleFor(x => x.name)
			.NotEmpty().WithMessage("Nome está vazio")
			.MinimumLength(2);

		RuleFor(x => x.email)
			.EmailAddress().WithMessage("E-mail invalido!")
			.NotEmpty().WithMessage("E-mail é mandatorio!");

		RuleFor(x => x.password)
			.NotEmpty().WithMessage("A senha é mandatoria!")
			.MinimumLength(7).WithMessage("A senha deve ter no minimo 7 caracteres");

		RuleFor(x => x.confirmPassword)
			.NotEmpty().WithMessage("A senha é mandatoria!")
			.Equal(x => x.email).WithMessage("Senhas Diferentes")
			.MinimumLength(7).WithMessage("A senha deve ter no minimo 7 caracteres");

		RuleFor(x => x.phone)
			.MinimumLength(6).WithMessage("Minimo de 6 caracteres");

		RuleFor(x => x.cpf)
			.MinimumLength(3).WithMessage("Minnimo de 3 caracteres");
	}
}
