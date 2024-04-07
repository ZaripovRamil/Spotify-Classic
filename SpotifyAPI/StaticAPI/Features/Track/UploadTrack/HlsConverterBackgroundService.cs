using Amazon.S3;
using Amazon.S3.Model;
using StaticAPI.Services.Interfaces;
using static StaticAPI.Constants.S3Storage;

namespace StaticAPI.Features.Track.UploadTrack;

public class HlsConverterBackgroundService : BackgroundService
{
    private readonly TimeSpan _idlePeriod = TimeSpan.FromSeconds(30); 
    
    private readonly IHlsConverter _hlsConverter;
    private readonly IAmazonS3 _s3Client;

    public HlsConverterBackgroundService(IHlsConverter hlsConverter, IAmazonS3 s3Client)
    {
        _hlsConverter = hlsConverter;
        _s3Client = s3Client;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (!await Amazon.S3.Util.AmazonS3Util.DoesS3BucketExistV2Async(_s3Client, TracksBucketName))
            await _s3Client.PutBucketAsync(TracksBucketName,stoppingToken);
        
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                var objects = await _s3Client.ListObjectsAsync(TracksPendingBucketName, stoppingToken);
                var tasks = objects.S3Objects.Select(obj => ProcessObjectAsync(obj.Key, stoppingToken));
                await Task.WhenAll(tasks);
            }
            catch (Exception e)
            {
                Console.WriteLine(e); // watta hell
            }
            
            await Task.Delay(_idlePeriod, stoppingToken);
        }
    }

    private async Task ProcessObjectAsync(string s3ObjName, CancellationToken stoppingToken)
    {
        var tempFileName = await DownloadS3ObjectToTempFileAsync(s3ObjName, stoppingToken);
        var tempDirectory = await ConvertMp3ToHlsAsync(tempFileName, s3ObjName);
        await UploadFilesAsync(tempDirectory, stoppingToken);
        await CleanupAsync(tempFileName, tempDirectory, s3ObjName, stoppingToken);
    }

    private async Task<string> DownloadS3ObjectToTempFileAsync(string s3ObjName, CancellationToken stoppingToken)
    {
        await using var fileStream =
            await _s3Client.GetObjectStreamAsync(TracksPendingBucketName, s3ObjName, null, stoppingToken);
        var tempFileName = Path.Combine(Path.GetTempPath(), s3ObjName);
        await using var tempFile = File.OpenWrite(tempFileName);
        await fileStream.CopyToAsync(tempFile, stoppingToken);
        return tempFileName;
    }

    private async Task<string> ConvertMp3ToHlsAsync(string tempFileName, string s3ObjName)
    {
        var fileName = Path.GetFileNameWithoutExtension(s3ObjName);
        var tempDirectory = Path.Combine(Path.GetTempPath(), fileName);
        await _hlsConverter.SaveHlsFromMp3Async(tempFileName, tempDirectory);
        return tempDirectory;
    }

    private async Task UploadFilesAsync(string tempDirectory, CancellationToken stoppingToken)
    {
        var hlsFiles = Directory.GetFiles(tempDirectory);
        var tasks = hlsFiles.Select(hlsFile => UploadAndDeleteFileAsync(hlsFile, stoppingToken));
        await Task.WhenAll(tasks);
    }

    private async Task UploadAndDeleteFileAsync(string hlsFile, CancellationToken stoppingToken)
    {
        var hlsFileName = Path.GetFileName(hlsFile);
        var putObjectRequest = new PutObjectRequest
        {
            BucketName = TracksBucketName,
            Key = hlsFileName,
            FilePath = hlsFile
        };
        await _s3Client.PutObjectAsync(putObjectRequest, stoppingToken);
        File.Delete(hlsFile);
    }

    private async Task CleanupAsync(string tempFileName, string tempDirectory, string s3ObjName, CancellationToken stoppingToken)
    {
        File.Delete(tempFileName);
        Directory.Delete(tempDirectory);
        await _s3Client.DeleteObjectAsync(TracksPendingBucketName, s3ObjName, stoppingToken);
    }
}