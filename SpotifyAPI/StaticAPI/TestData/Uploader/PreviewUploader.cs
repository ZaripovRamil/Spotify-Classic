using Amazon.S3;
using Amazon.S3.Model;

namespace StaticAPI.TestData.Uploader;

public class PreviewUploader : IUploader
{
    private readonly IAmazonS3 _client;
    private const string BucketName = Constants.S3Storage.PreviewsBucketName;

    public PreviewUploader(IAmazonS3 client)
    {
        _client = client;
    }

    public async Task UploadAsync(string filePath, CancellationToken cancellationToken = default)
    {
        var fileName = Path.GetFileName(filePath);
        if (await IUploader.DoesObjectExistAsync(_client, BucketName, fileName))
            return;
        
        var putRequest = new PutObjectRequest
        {
            BucketName = BucketName,
            Key = fileName,
            FilePath = filePath
        };
        
        await _client.PutObjectAsync(putRequest, cancellationToken);
    }

    public async Task EnsureBucketExistsAsync()
    {
        if (! await Amazon.S3.Util.AmazonS3Util.DoesS3BucketExistV2Async(_client, BucketName))
            await _client.PutBucketAsync(BucketName);
    }
}