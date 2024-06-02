namespace Utils.RabbitMq;

public static class RabbitMqConstants
{
    public static string GetListenQueue(string albumId) => $"listen_queue_{albumId}";
    public static string GetAlbumListenQueue(string albumId) => $"album_listen_queue_{albumId}";
}