using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models.Configuration;
using RabbitMQ.Client;

namespace Utils.ServiceCollectionExtensions;

public static class AddRabbitMqConnectionFactoryExtension
{
    public static IServiceCollection AddRabbitMqConnectionFactory(this IServiceCollection services, IConfiguration configuration)
    {
        var rabbitConfiguration = configuration.GetSection("RabbitMqConfig").Get<RabbitMqConfig>();
        if (rabbitConfiguration is null)
            throw new ArgumentException("RabbitMqConfig in provided configuration is null");
        var factory = new ConnectionFactory
        {
            HostName = rabbitConfiguration.Host,
            UserName = rabbitConfiguration.User,
            Password = rabbitConfiguration.Pass
        };
        services.AddSingleton(factory);
        return services;
    }
}