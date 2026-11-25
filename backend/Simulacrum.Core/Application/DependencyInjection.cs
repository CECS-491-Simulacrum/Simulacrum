using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Simulacrum.Application.Services;

namespace Simulacrum.Application;

public static class DependencyInjection
{
    // register implementation so the application can receive it
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddScoped<ObjectService>();
        
        return services;
    }
}