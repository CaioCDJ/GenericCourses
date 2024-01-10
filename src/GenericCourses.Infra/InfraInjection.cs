using Microsoft.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;

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
                );
        });

        return services;
    }
}
