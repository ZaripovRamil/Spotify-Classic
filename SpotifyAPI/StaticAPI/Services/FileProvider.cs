namespace StaticAPI.Services;

public class FileProvider : IFileProvider
{
    private static string CombinePaths(string assetName, string fileName) =>
        Path.Combine("Assets", assetName, fileName);
    
    public Stream? GetFileAsStream(string assetName, string fileName)
    {
        var path = CombinePaths(assetName, fileName);
        return !File.Exists(path)
            ? null
            : new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous);
    }

    public long GetFileLength(string assetName, string fileName)
    {
        var path = CombinePaths(assetName, fileName);
        return !File.Exists(path) ? 0 : new FileInfo(path).Length;
    }

    public bool Exists(string assetName, string fileName)
    {
        var path = CombinePaths(assetName, fileName);
        return File.Exists(path);
    }

    public async Task UploadAsync(string assetName, string fileName, Stream fileStream)
    {
        var path = CombinePaths(assetName, fileName);
        await using var newFile = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write, 4096,
            FileOptions.Asynchronous);
        await fileStream.CopyToAsync(newFile);
    }
}