using System.Reflection;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using Models.Configuration;

namespace Utils.ServiceCollectionExtensions;

public static class AddMasstransitRabbitMqExtension
{
    public static IServiceCollection AddMasstransitRabbitMq(this IServiceCollection services,
        RabbitMqConfig rabbitConfiguration, Assembly consumersAssembly)
    {
        services.AddMassTransit(c =>
        {
            c.SetKebabCaseEndpointNameFormatter();
            c.AddConsumers(consumersAssembly);
            c.UsingRabbitMq((ctx, cfg) =>
            {
                cfg.Host(rabbitConfiguration.Host, "/", rc =>
                {
                    rc.Username(rabbitConfiguration.User);
                    rc.Password(rabbitConfiguration.Pass);
                });

                cfg.ConfigureEndpoints(ctx);
            });
        });
        return services;
    }
}