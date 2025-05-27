
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using GenericCourses.Application.Features.Auth;
using GenericCourses.Web.Models;
using FluentValidation;
namespace GenericCourses.Web.Validations;

public static class ValidationsDependency {

	public static IServiceCollection Validations(
		this IServiceCollection services
	) {
		services.AddScoped<IValidator<StoreVideoForm>, StoreVideoFormValidator>();
		services.AddScoped<IValidator<RegisterRequest>, RegisterRequestValidator>();
		services.AddScoped<IValidator<LoginRequest>, LoginRequestValidator>();
		return services;
	}
}
