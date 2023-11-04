using System.Reflection;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models.Configuration;

namespace Utils.ServiceCollectionExtensions;

public static class AddMasstransitRabbitMqExtension
{
    public static IServiceCollection AddMasstransitRabbitMq(this IServiceCollection services,
        IConfiguration configuration, Assembly consumersAssembly)
    {
        var rabbitConfiguration = configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>();
        if (rabbitConfiguration is null)
            throw new ArgumentException("RabbitMqConfig in provided configuration is null");
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