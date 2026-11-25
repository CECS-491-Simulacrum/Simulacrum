using Simulacrum.Application.Interfaces;
using Simulacrum.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Simulacrum.Infrastructure.Persistence;
using Microsoft.Extensions.Options;

namespace Simulacrum.Infrastructure;

public static class DependencyInjection
{
    /** register relationship with ASP.NET Core's dependency injection system
     *
     * EF Core General Guide: https://learn.microsoft.com/en-us/ef/core/dbcontext-configuration/
     * Npgsql provider-specific ASP.NET Core DI instructions: https://www.npgsql.org/efcore/?tabs=aspnet
     */
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString);
        });

        // when class requests IApplicationDbContext, ASP.NET Core will give ApplicationDbContext instance
        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());

        return services;
    }
}