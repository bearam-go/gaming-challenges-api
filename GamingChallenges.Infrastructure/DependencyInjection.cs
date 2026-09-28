using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using GamingChallenges.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GamingChallenges.Infrastructure;
public static class DependencyInjection
{
    // public static AddInfrastructureServices : IServiceCollection
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>( options =>
            {
                var configurationString = configuration.GetConnectionString("DefaultConnection");
                options.UseSqlite(configurationString);
            }
        );
        return services;
    }
}