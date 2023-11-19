using Amazon.S3;

namespace StaticAPI.TestData.Uploader;

public interface IUploader
{
    Task UploadAsync(string filePath, CancellationToken cancellationToken = default);
    Task EnsureBucketExistsAsync();
    
    protected static async Task<bool> DoesObjectExistAsync(IAmazonS3 client, string bucketName, string key)
    {
        try
        {
            await client.GetObjectMetadataAsync(bucketName, key);
            return true;
        }
        catch (AmazonS3Exception ex)
        {
            if (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
                return false;
            throw;
        }
    }
}