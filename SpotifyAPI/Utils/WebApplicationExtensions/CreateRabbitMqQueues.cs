using DatabaseServices.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Utils.RabbitMq;

namespace Utils.WebApplicationExtensions;

public static class CreateRabbitMqQueuesExtension
{
    public static async Task CreateRabbitMqQueuesAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var rabbitMqService = scope.ServiceProvider.GetRequiredService<IRabbitMqService>();
        var repository = scope.ServiceProvider.GetRequiredService<IAlbumRepository>();
        var queueArgs = new Dictionary<string, object>
        {
            ["x-message-ttl"] = 10000
        };
        await foreach (var album in repository.GetAllAsync())
        {
            rabbitMqService.CreateQueue(RabbitMqConstants.GetListenQueue(album.Id), queueArgs);
            rabbitMqService.CreateExchange(RabbitMqConstants.GetListenQueue(album.Id), "fanout");
        }
    }
}