using Models.Metadata;

namespace StaticAPI.Services.Interfaces;

public interface IFileUploader
{
    Task UploadFileAsync(IFormFile file, Metadata metadata,  CancellationToken cancellationToken = default);
}