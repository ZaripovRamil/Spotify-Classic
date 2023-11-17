using Amazon.S3;
using Amazon.S3.Model;

namespace StaticAPI.Services;

public class S3Storage : IFileProvider
{
    private readonly IAmazonS3 _client;

    public S3Storage(IAmazonS3 client)
    {
        _client = client;
    }

    public async Task<Stream?> GetFileAsStreamAsync(string assetName, string fileName,
        CancellationToken cancellationToken = default)
    {
        var obj = await _client.GetObjectAsync(assetName, fileName, cancellationToken);
        return obj?.ResponseStream;
    }

    public async Task UploadAsync(string assetName, string fileName, Stream fileStream,
        CancellationToken cancellationToken = default)
    {
        await _client.EnsureBucketExistsAsync(assetName);
        var request = new PutObjectRequest
        {
            AutoCloseStream = true,
            AutoResetStreamPosition = true,
            BucketName = assetName,
            FilePath = fileName,
            InputStream = fileStream
        };
        await _client.PutObjectAsync(request, cancellationToken);
    }

    public async Task DeleteFileAsync(string assetName, string fileName, CancellationToken cancellationToken = default)
    {
        await _client.DeleteObjectAsync(assetName, fileName, cancellationToken);
    }
}