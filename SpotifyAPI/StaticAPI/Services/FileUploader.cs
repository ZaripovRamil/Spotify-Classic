using Models.Metadata;

namespace StaticAPI.Services;

public class FileUploader: IFileUploader
{
    private readonly IFileProcessingService _fileProcessingService;
    private readonly IStorage _storage;

    public FileUploader(IFileProcessingService fileProcessingService, IStorage fp)
    {
        _fileProcessingService = fileProcessingService;
        _storage = fp;
    }
    public async Task UploadFileAsync(IFormFile file, Metadata metadata,  CancellationToken cancellationToken)
    {
        var uploadMetadataTask = Task.Run(() =>
        {
            // redis.upload(metadata)
            // redis[metadata].counter++
        });

        var uploadFileTask = Task.Run(async () => 
        {
            var tempBucketName = await _fileProcessingService.GetBucketByMetadata(metadata, true);
            await _storage.UploadAsync(tempBucketName, file.FileName, file.OpenReadStream(),
                cancellationToken);
            // s3.upload(file, temp_bucket)
            // redis[metadata].counter++

        });
        
        await Task.WhenAll(uploadMetadataTask, uploadFileTask);
        
        //if redis[metadata].counter() == 2: eventuate_processing();
    }
}