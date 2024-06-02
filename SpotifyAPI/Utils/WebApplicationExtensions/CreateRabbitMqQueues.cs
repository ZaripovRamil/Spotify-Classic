using DatabaseServices.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Utils.RabbitMq;

namespace Utils.WebApplicationExtensions;

public static class CreateRabbitMqQueuesExtension
{
    public static void CreateRabbitMqQueues(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var rabbitMqService = scope.ServiceProvider.GetRequiredService<IRabbitMqService>();
        rabbitMqService.CreateQueue(RabbitMqConstants.GlobalListenQueue);
        rabbitMqService.CreateExchange(RabbitMqConstants.GlobalListenQueue, "fanout");
        var repository = app.Services.GetService<IAlbumRepository>();
        foreach (var album in repository!.GetWithFilters(null, null, null, null, null))
        {
            rabbitMqService.CreateQueue($"{RabbitMqConstants.AlbumListenQueuePrefix}{album.Id}");
            rabbitMqService.CreateExchange($"{RabbitMqConstants.AlbumListenQueuePrefix}{album.Id}", "fanout");
        }
    }
}