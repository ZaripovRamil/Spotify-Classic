using Models.Metadata;
using static StaticAPI.Constants.S3Storage;

namespace StaticAPI.Services;

public class FileProcessingService : IFileProcessingService
{
    public Task<string> GetBucketByMetadata(Metadata metadata, bool isTemp)
    {
        if (metadata.GetType() == typeof(ImageMetadata)) return isTemp ? Task.FromResult(PreviewsTempBucketName) : Task.FromResult(TracksTempBucketName);
        if (metadata.GetType() == typeof(TrackMetadata)) return isTemp ? Task.FromResult(PreviewsBucketName) : Task.FromResult(TracksBucketName);
        throw new Exception(); // тут поправьте, я просто так написала
    }

    public Task EventuateProcessing(Metadata item)
    {
        throw new NotImplementedException();
    }

    public Task ClearRedis()
    {
        throw new NotImplementedException();
    }
}