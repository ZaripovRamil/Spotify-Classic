using Models.Metadata;

namespace StaticAPI.Services.Interfaces;

public interface IFileProcessingService
{
    Task<string> GetBucketByMetadata(Metadata metadata, bool isTemp);
    Task EventuateProcessing(Metadata item, CancellationToken cancellationToken);

    Task ClearRedis(CancellationToken cancellationToken);
}