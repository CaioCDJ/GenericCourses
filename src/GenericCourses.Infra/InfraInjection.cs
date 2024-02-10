using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GenericCourses.Infra.Persistence;
using GenericCourses.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using EFCore.NamingConventions;

namespace GenericCourses.Infra;

public static class InfraInjection
{

    public static IServiceCollection addInfra(
        this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
                )
            .UseSnakeCaseNamingConvention();
        });
        
        services.AddScoped<PostRepository>();
        return services;
    }
}
