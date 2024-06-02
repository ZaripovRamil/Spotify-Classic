namespace Utils.RabbitMq;

public static class RabbitMqConstants
{
    public const string GlobalListenQueue = "global_listen_queue";

    public static string GetListenQueue(string albumId) => $"listen_queue_{albumId}";
    public const string AlbumListenQueuePrefix = "albun_listen_queue_";
}