using External.Redis;
using Models.Metadata;
using StaticAPI.Services.Interfaces;

namespace StaticAPI.Services;

public class FileUploader: IFileUploader
{
    private readonly IFileProcessingService _fileProcessingService;
    private readonly IStorage _storage;
    private readonly IRedisCache _redisCache;
    
    public FileUploader(IFileProcessingService fileProcessingService, IStorage fp, IRedisCache redisCache)
    {
        _fileProcessingService = fileProcessingService;
        _storage = fp;
        _redisCache = redisCache;
    }
    public async Task UploadFileAsync(IFormFile file, Metadata metadata,  CancellationToken cancellationToken = default)
    {
        var uploadMetadataTask = Task.Run(async () =>
        {
            await _redisCache.Set(metadata);
            await _redisCache.IncrementCounter(metadata.FileId);
        }, cancellationToken);

        var uploadFileTask = Task.Run(async () => 
        {
            var tempBucketName = await _fileProcessingService.GetBucketByMetadata(metadata, true);
            await _storage.UploadAsync(tempBucketName, metadata.FileName, file.OpenReadStream(),
                cancellationToken);
            await _redisCache.IncrementCounter(metadata.FileId);
        }, cancellationToken);
        
        await Task.WhenAll(uploadMetadataTask, uploadFileTask);

        var counter = await _redisCache.GetCounter(metadata.FileId);
        if (counter == 2)
            await _fileProcessingService.EventuateProcessing(metadata, cancellationToken);
    }
}