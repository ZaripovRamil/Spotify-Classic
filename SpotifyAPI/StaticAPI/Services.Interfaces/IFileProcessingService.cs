using Models.Metadata;

namespace StaticAPI.Services;


public interface IFileProcessingService
{
    Task<string> GetBucketByMetadata(Metadata metadata, bool isTemp);
    Task EventuateProcessing(Metadata item);

    Task ClearRedis();
}