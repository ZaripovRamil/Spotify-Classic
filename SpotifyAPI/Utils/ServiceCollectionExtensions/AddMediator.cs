using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Utils.CQRS.MediatorBehaviors;

namespace Utils.ServiceCollectionExtensions;

public static class AddMediatorExtensions
{
    public static IServiceCollection AddMediatorForAssembly(this IServiceCollection services, Assembly assembly)
    {
        return services.AddMediatR(c => c.RegisterServicesFromAssembly(assembly));
    }

    public static IServiceCollection AddPipelineBehaviors(this IServiceCollection services)
    {
        return services
            .AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
    }
}