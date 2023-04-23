namespace StaticAPI.Services;

public class FileProvider : IFileProvider
{
    public Stream? GetFileAsStream(string path) => !File.Exists(path)
        ? null
        : new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous);

    public long GetFileLength(string path) => !File.Exists(path) ? 0 : new FileInfo(path).Length;
    public bool Exists(string path) => File.Exists(path);
}