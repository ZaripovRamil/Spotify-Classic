using Amazon.S3;
using StaticAPI.TestData.Uploader;

namespace StaticAPI.WebApplicationExtensions;

public static class EnsureAssetsDataUploadedExtension
{
    public static async Task EnsureTestDataUploadedAsync(this WebApplication app)
    {
        var s3Client = app.Services.GetRequiredService<IAmazonS3>();
        await S3TestDataProvider.EnsureTestDataUploadedAsync(s3Client);
    }
}