namespace PlayingService.Services;

public class FileProvider : IFileProvider
{
    // TODO: may be change logic to pass content-type for file, not the exact path with extension
    // to be able find 1.jpeg when searching for 1.jpg
    public Stream? GetFileAsStream(string path) => !File.Exists(path) ? null : new FileStream(path, FileMode.Open);

    public long GetFileLength(string path) => !File.Exists(path) ? 0 : new FileInfo(path).Length;
}