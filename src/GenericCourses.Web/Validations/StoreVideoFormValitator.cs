using FluentValidation;
using GenericCourses.Web.Models;

namespace GenericCourses.Web.Validations;

public class StoreVideoFormValidator :AbstractValidator<StoreVideoForm>{

	public StoreVideoFormValidator(){
		RuleFor(x=>x.title)
			.NotEmpty().WithMessage("Este campo é requerido")
			.MinimumLength(3).WithMessage("O valor minimo de caracters é 3");
		
		// RuleFor(x=>x.order)
		// 	.GreaterThan(0).WithMessage("Este numero precisa ser maior que 0");

		RuleFor(x=>x.video_url)
			.NotEmpty().WithMessage("Este campo é requerido");

		RuleFor(x=>x.desc)
			.NotEmpty().WithMessage("Este campo é requerido");
	}
}
