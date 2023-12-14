using Models.Metadata;
using static StaticAPI.Constants.S3Storage;

namespace StaticAPI.Services;

public class FileProcessingService : IFileProcessingService
{
    public async Task<string> GetBucketByMetadata(Metadata metadata, bool isTemp)
    {
        if (metadata.GetType() == typeof(ImageMetadata)) return isTemp ? PreviewsTempBucketName : TracksTempBucketName;
        if (metadata.GetType() == typeof(TrackMetadata)) return isTemp ? PreviewsBucketName : TracksBucketName;
        throw new Exception(); // тут поправьте, я просто так написала
    }

    public async Task EventuateProcessing(Metadata item)
    {
        throw new NotImplementedException();
    }
}