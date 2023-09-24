namespace StaticAPI.Services;

public class FileProvider : IFileProvider
{
    private const string AssetsPath = "/assets";
    
    public Stream? GetFileAsStream(string assetName, string fileName)
    {
        var path = Path.Combine(AssetsPath, assetName, fileName);
        return !File.Exists(path)
            ? null
            : new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous);
    }

    public long GetFileLength(string assetName, string fileName)
    {
        var path = Path.Combine(AssetsPath, assetName, fileName);
        return !File.Exists(path) ? 0 : new FileInfo(path).Length;
    }

    public bool Exists(string assetName, string fileName)
    {
        var path = Path.Combine(AssetsPath, assetName, fileName);
        return File.Exists(path);
    }

    public async Task UploadAsync(string assetName, string fileName, Stream fileStream)
    {
        var path = Path.Combine(AssetsPath, assetName);
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        path = Path.Combine(path, fileName);
        await using var newFile = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write, 4096,
            FileOptions.Asynchronous);
        await fileStream.CopyToAsync(newFile);
    }

    public async Task DeleteFileAsync(string assetName, string fileName)
    {
        await Task.Run(() => File.Delete(Path.Combine(AssetsPath, assetName, fileName)));
    }
}