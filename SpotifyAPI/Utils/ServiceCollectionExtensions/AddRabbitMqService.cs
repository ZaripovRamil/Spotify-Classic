using Microsoft.Extensions.DependencyInjection;
using Utils.RabbitMq;

namespace Utils.ServiceCollectionExtensions;

public static class AddRabbitMqServiceExtension
{
    public static IServiceCollection AddRabbitMqService(this IServiceCollection services)
    {
        services.AddSingleton<IRabbitMqService, RabbitMqService>();
        return services;
    }
}