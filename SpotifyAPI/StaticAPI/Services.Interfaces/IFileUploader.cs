using Models.Metadata;

namespace StaticAPI.Services;

public interface IFileUploader
{
    Task UploadFileAsync(IFormFile file, Metadata metadata,  CancellationToken cancellationToken = default);
}