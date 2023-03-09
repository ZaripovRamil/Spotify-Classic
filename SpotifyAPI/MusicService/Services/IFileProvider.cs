namespace MusicService.Services;

public interface IFileProvider
{
    public Stream? GetFileAsStream(string path);
}