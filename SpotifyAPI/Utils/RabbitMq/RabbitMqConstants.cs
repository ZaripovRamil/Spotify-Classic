namespace Utils.RabbitMq;

public static class RabbitMqConstants
{
    public static string GetAlbumListenQueue(string albumId) => $"album_listen_queue_{albumId}";
}