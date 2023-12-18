
using External.Redis;
using Models.Metadata;
using StaticAPI.Services.Interfaces;
using static StaticAPI.Constants.S3Storage;

namespace StaticAPI.Services;

public class FileProcessingService : IFileProcessingService
{
    private readonly IRepository<ImageMetadata> _imageMetadataRepository;
    private readonly IRepository<TrackMetadata> _trackMetadataRepository;
    private readonly IStorage _storage;
    private readonly IRedisCache _redisCache;
    public FileProcessingService(IRepository<ImageMetadata> imageMetadataRepository,
        IRepository<TrackMetadata> trackMetadataRepository, IStorage fp, IRedisCache redisCache)
    {
        _imageMetadataRepository = imageMetadataRepository;
        _trackMetadataRepository = trackMetadataRepository;
        _storage = fp;
        _redisCache = redisCache;
    }
    
    public Task<string> GetBucketByMetadata(Metadata metadata, bool isTemp)
    {
        if (metadata.GetType() == typeof(ImageMetadata)) return isTemp ? Task.FromResult(PreviewsTempBucketName) : Task.FromResult(PreviewsBucketName);
        if (metadata.GetType() == typeof(TrackMetadata)) return isTemp ? Task.FromResult(TracksTempBucketName) : Task.FromResult(TracksPendingBucketName);
        throw new ArgumentException($"Unsupported metadata type {metadata.GetType()}");
    }
    

    public async Task EventuateProcessing(Metadata item, CancellationToken cancellationToken)
    {
        await UploadToMongo(item);
        var tempBucket = await GetBucketByMetadata(item, true);
        await using var fileStream =
            await _storage.GetFileAsStreamAsync(tempBucket, item.FileName,  cancellationToken);
        if (fileStream != null)
        {
            var bucket = await GetBucketByMetadata(item, false);
            await _storage.UploadAsync(bucket, item.FileName, fileStream,
                    cancellationToken);
        }

        await _storage.DeleteFileAsync(tempBucket, item.FileName, cancellationToken);

        var metadata = await _redisCache.Get<Metadata>(item.FileId);
        if (metadata != null)
        {
            metadata.IsProcessed = true;
            await _redisCache.Set(metadata);
        }
    }

    public async Task ClearRedis(CancellationToken cancellationToken)
    {
        var items = await _redisCache.GetAll<Metadata>();

        foreach (var item in items)
        {
            if (item is null) continue;
            if (item.IsProcessed) _redisCache.Delete<Metadata>(item.FileId);
            var counter = await _redisCache.GetCounter(item.FileId);

            if (counter == 2)
            { 
                await EventuateProcessing(item, cancellationToken);
                _redisCache.Delete<Metadata>(item.FileId);
            }
        }
    }

    private async Task UploadToMongo(Metadata item)
    {
        var metadataType = item.GetType();
        if (metadataType == typeof(ImageMetadata))
            await _imageMetadataRepository.CreateAsync((ImageMetadata)item);
        else if (metadataType == typeof(TrackMetadata))
            await _trackMetadataRepository.CreateAsync((TrackMetadata)item);
    }
}