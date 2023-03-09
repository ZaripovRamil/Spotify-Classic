namespace MusicService.Services;

public class FileProvider : IFileProvider
{
    public Stream? GetFileAsStream(string path) => !File.Exists(path) ? null : new FileStream(path, FileMode.Open);
}