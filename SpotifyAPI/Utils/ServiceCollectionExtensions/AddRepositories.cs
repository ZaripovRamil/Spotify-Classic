using DatabaseServices.Services.Repositories.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Utils.ServiceCollectionExtensions;

public static class AddRepositoriesExtension
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext(configuration);
        
        var repositoriesAssembly = typeof(Repository).Assembly;
        var repositories = repositoriesAssembly.GetTypes().Where(t => t.IsClass && t.BaseType == typeof(Repository));
        foreach (var type in repositories)
        {
            var repoInterface = type.GetInterfaces().First();
            services.AddScoped(repoInterface, type);
        }

        return services;
    }
}