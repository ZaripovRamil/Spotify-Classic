using External.Redis;
using Models.Metadata;
using static StaticAPI.Constants.S3Storage;

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
    public async Task UploadFileAsync(IFormFile file, Metadata metadata,  CancellationToken cancellationToken)
    {
        var uploadMetadataTask = Task.Run(async () =>
        {
            await _redisCache.Set(metadata);
            await _redisCache.IncrementCounter(metadata.FileId);
        });

        var uploadFileTask = Task.Run(async () => 
        {
            var tempBucketName = await _fileProcessingService.GetBucketByMetadata(metadata, true);
            await _storage.UploadAsync(tempBucketName, file.FileName, file.OpenReadStream(),
                cancellationToken);
            await _redisCache.IncrementCounter(metadata.FileId);
        });
        
        await Task.WhenAll(uploadMetadataTask, uploadFileTask);

        /*var r = await _redisCache.Get<ImageMetadata>(metadata.FileId);
        
        if (r is not null)
            Console.WriteLine(r.FileId);
        else
        {
            Console.WriteLine("упс");
        }
        
        await using var fileStream =
            await _storage.GetFileAsStreamAsync(PreviewsTempBucketName, file.FileName,  cancellationToken);
        
        if (fileStream is not null)
            Console.WriteLine(fileStream.Length);
        else
        {
            Console.WriteLine("упс");
        } это проверка была пусть будет пока*/

        var counter = await _redisCache.GetCounter(metadata.FileId);
        Console.WriteLine(counter);
        if (counter == 2)
            await _fileProcessingService.EventuateProcessing(metadata);
    }
}