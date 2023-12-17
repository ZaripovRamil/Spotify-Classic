using Microsoft.AspNetCore.Mvc;
using Models.Metadata;
using Utils.Bind;

namespace StaticAPI.Dto.FileDataDTO;

public class ImageDataDto
{
    public IFormFile? File { get; set; }

    [ModelBinder(BinderType = typeof(FormDataJsonBinder))]
    public ImageMetadata? ImageMetadata { get; set; } = new();
}