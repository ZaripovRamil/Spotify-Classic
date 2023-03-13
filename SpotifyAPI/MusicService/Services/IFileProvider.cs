namespace MusicService.Services;

public interface IFileProvider
{
    public Stream? GetFileAsStream(string path);

    public long GetFileLength(string path);
}