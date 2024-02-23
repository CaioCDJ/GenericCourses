using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using MediatR;

namespace GenericCourses.Application;

public static class ApplicationInjection
{

    public static IServiceCollection addApplication(
        this IServiceCollection services
        )
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationInjection).Assembly));
        return services;
    }
}

