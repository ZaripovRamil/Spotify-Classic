using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Utils.ServiceCollectionExtensions;

public static class AddDbContextExtension
{
    public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString(configuration["POSTGRES_DB"]!),
                b => b.MigrationsAssembly("Database")));
        
        return services;
    }
}