using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Utils.ServiceCollectionExtensions;

public static class AddMediatorExtension
{
    public static void AddMediatorForAssembly(this IServiceCollection services, Assembly assembly)
    {
        services.AddMediatR(c => c.RegisterServicesFromAssembly(assembly));
    }
}