using Microsoft.Extensions.DependencyInjection;

namespace Utils.CQRS.ServiceDefinition;

[AttributeUsage(AttributeTargets.Class)]
public class ServiceDefinitionAttribute : Attribute
{
    public ServiceLifetime Lifetime { get; }

    public ServiceDefinitionAttribute(ServiceLifetime lifetime)
    {
        Lifetime = lifetime;
    }
}