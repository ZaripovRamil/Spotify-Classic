using Utils.LocalRun;

namespace StaticAPI.Services;

public class FileProvider : IFileProvider
{
    private readonly string _assetsPath = GetAssetsFullPath();
    
    public Task<Stream?> GetFileAsStreamAsync(string assetName, string fileName,
        CancellationToken cancellationToken = default)
    {
        var path = Path.Combine(_assetsPath, assetName, fileName);
        path = Path.GetFullPath(path);
        if (!path.StartsWith(_assetsPath, StringComparison.Ordinal)) return Task.FromResult<Stream?>(null);
        return Task.FromResult<Stream?>(!File.Exists(path)
            ? null
            : new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous));
    }

    public async Task UploadAsync(string assetName, string fileName, Stream fileStream,
        CancellationToken cancellationToken = default)
    {
        var path = Path.Combine(_assetsPath, assetName);
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);
        path = Path.Combine(path, fileName);
        await using var newFile = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write, 4096,
            FileOptions.Asynchronous);
        await fileStream.CopyToAsync(newFile, cancellationToken);
    }

    public async Task DeleteFileAsync(string assetName, string fileName, CancellationToken cancellationToken = default)
    {
        await Task.Run(() => File.Delete(Path.Combine(_assetsPath, assetName, fileName)), cancellationToken);
    }

    private static string GetAssetsFullPath()
    {
        return Path.GetFullPath(ApplicationEnvironment.IsContainer ? "/assets" : "Assets");
    }
}