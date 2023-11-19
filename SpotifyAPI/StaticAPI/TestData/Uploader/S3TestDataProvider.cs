using Amazon.S3;

namespace StaticAPI.TestData.Uploader;

public static class S3TestDataProvider
{
    private static readonly string AssetsPath = Path.Combine("TestData", "Data");
    
    public static async Task EnsureTestDataUploadedAsync(IAmazonS3 client)
    {
        var directories = Directory.GetDirectories(AssetsPath);
        var tasks = directories.Select(directory => UploadDirectoryAsync(client, directory));
        await Task.WhenAll(tasks);
    }

    private static async Task UploadDirectoryAsync(IAmazonS3 client, string directory)
    {
        var directoryName = Path.GetFileName(directory);
        var uploader = GetUploader(client, directoryName);
        await uploader.EnsureBucketExistsAsync();
        var files = Directory.GetFiles(directory);
        var tasks = files.Select(file => uploader.UploadAsync(file));
        await Task.WhenAll(tasks);
    }

    private static IUploader GetUploader(IAmazonS3 client, string directoryName) =>
        directoryName switch
        {
            "Tracks" => new TrackUploader(client),
            "Previews" => new PreviewUploader(client),
            _ => throw new ArgumentException($"Uploader for directory {directoryName} is not provided")
        };
}