using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Utils.CQRS.ServiceDefinition;

namespace Utils.ServiceCollectionExtensions;

public static class AddDefinedServicesExtension
{
    public static IServiceCollection AddDefinedServices(this IServiceCollection services, Assembly assembly)
    {
        var serviceTypes = assembly.GetTypes()
            .Where(t => t.GetCustomAttributes(typeof(ServiceDefinitionAttribute), false).Any());

        foreach (var serviceType in serviceTypes)
        {
            var serviceAttribute = serviceType.GetCustomAttribute<ServiceDefinitionAttribute>()!;

            var implementedInterfaces = serviceType.GetInterfaces();

            foreach (var implementedInterface in implementedInterfaces)
                switch (serviceAttribute.Lifetime)
                {
                    case ServiceLifetime.Scoped:
                        services.AddScoped(implementedInterface, serviceType);
                        break;
                    case ServiceLifetime.Singleton:
                        services.AddSingleton(implementedInterface, serviceType);
                        break;
                    case ServiceLifetime.Transient:
                    default:
                        services.AddTransient(implementedInterface, serviceType);
                        break;
                }
        }

        return services;
    }
}