namespace StaticAPI.Services;

public interface IStorage
{
    public Task<Stream?> GetFileAsStreamAsync(string assetName, string fileName,
        CancellationToken cancellationToken = default);
    public Task UploadAsync(string assetName, string fileName, Stream fileStream,
        CancellationToken cancellationToken = default);
    public Task DeleteFileAsync(string assetName, string fileName, CancellationToken cancellationToken = default);
}