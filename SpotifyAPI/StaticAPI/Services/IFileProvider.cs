namespace StaticAPI.Services;

public interface IFileProvider
{
    public Stream? GetFileAsStream(string assetName, string fileName);
    public long GetFileLength(string assetName, string fileName);
    public bool Exists(string assetName, string fileName);
    public Task UploadAsync(string assetName, string fileName, Stream fileStream);
}