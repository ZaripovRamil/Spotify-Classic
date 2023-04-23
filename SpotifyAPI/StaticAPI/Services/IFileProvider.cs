namespace StaticAPI.Services;

public interface IFileProvider
{
    public Stream? GetFileAsStream(string path);
    public long GetFileLength(string path);
    public bool Exists(string path);
}