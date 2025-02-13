using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GenericCourses.Infra.Persistence;
using GenericCourses.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GenericCourses.Infra;

public static class InfraInjection {

	public static IServiceCollection addInfra(
		this IServiceCollection services, IConfiguration configuration) {
		services.AddDbContext<AppDbContext>(options => {
			options.UseNpgsql(
				configuration.GetConnectionString("DefaultConnection"),
				b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName).CommandTimeout(100)
				)
			.UseSnakeCaseNamingConvention();
		});
		services.AddScoped<IVideosRepository, VideosRepository>();
		services.AddScoped<IPostRepository, PostRepository>();
		services.AddScoped<InstructorRepository>();
		services.AddScoped<IAuthRepository, AuthRepository>();
		services.AddScoped<ICategoriesRepository, CategoriesRepository>();
		services.AddScoped<ISubscriptionPlanRepository, SubscriptionPlanRepository>();
		services.AddScoped<IModulesRepository, ModulesRepository>();
		services.AddScoped<ICourseRepository, CourseRepository>();
		return services;

	}
}
