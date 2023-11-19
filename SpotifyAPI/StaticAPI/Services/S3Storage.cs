using Amazon.S3;
using Amazon.S3.Model;

namespace StaticAPI.Services;

public class S3Storage : IStorage
{
    private readonly IAmazonS3 _s3Client;

    public S3Storage(IAmazonS3 s3Client)
    {
        _s3Client = s3Client;
    }

    public async Task<Stream?> GetFileAsStreamAsync(string assetName, string fileName,
        CancellationToken cancellationToken = default)
    {
        var obj = await _s3Client.GetObjectAsync(assetName, fileName, cancellationToken);
        return obj?.ResponseStream;
    }

    public async Task UploadAsync(string assetName, string fileName, Stream fileStream,
        CancellationToken cancellationToken = default)
    {
        if (!await Amazon.S3.Util.AmazonS3Util.DoesS3BucketExistV2Async(_s3Client, assetName))
            await _s3Client.PutBucketAsync(assetName, cancellationToken);
        
        var request = new PutObjectRequest
        {
            AutoCloseStream = true,
            AutoResetStreamPosition = true,
            BucketName = assetName,
            Key = fileName,
            InputStream = fileStream
        };
        
        await _s3Client.PutObjectAsync(request, cancellationToken);
    }

    public async Task DeleteFileAsync(string assetName, string fileName, CancellationToken cancellationToken = default)
    {
        await _s3Client.DeleteObjectAsync(assetName, fileName, cancellationToken);
    }
}