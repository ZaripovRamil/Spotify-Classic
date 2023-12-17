namespace StaticAPI.Services;

using Models.Metadata;

public interface IFileProcessingService
{
    Task<string> GetBucketByMetadata(Metadata metadata, bool isTemp);
    Task EventuateProcessing(Metadata item);

    Task ClearRedis();
}