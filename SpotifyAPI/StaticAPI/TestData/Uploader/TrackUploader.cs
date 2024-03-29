using Amazon.S3;
using Amazon.S3.Model;

namespace StaticAPI.TestData.Uploader;

public class TrackUploader : IUploader
{
    private readonly IAmazonS3 _client;
    private const string UploadBucket = Constants.S3Storage.TracksPendingBucketName;
    private const string CheckBucket = Constants.S3Storage.TracksBucketName;
    
    public TrackUploader(IAmazonS3 client)
    {
        _client = client;
    }

    public async Task UploadAsync(string filePath, CancellationToken cancellationToken = default)
    {
        var fileName = Path.GetFileName(filePath);
        if (await IUploader.DoesObjectExistAsync(_client, CheckBucket, fileName))
            return;
        
        var putRequest = new PutObjectRequest
        {
            BucketName = UploadBucket,
            Key = fileName,
            FilePath = filePath
        };
        
        await _client.PutObjectAsync(putRequest, cancellationToken);
    }

    public async Task EnsureBucketExistsAsync()
    {
        if (! await Amazon.S3.Util.AmazonS3Util.DoesS3BucketExistV2Async(_client, UploadBucket))
            await _client.PutBucketAsync(UploadBucket);
        if (! await Amazon.S3.Util.AmazonS3Util.DoesS3BucketExistV2Async(_client, CheckBucket))
            await _client.PutBucketAsync(CheckBucket);
    }
}