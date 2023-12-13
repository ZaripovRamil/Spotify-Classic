using Microsoft.AspNetCore.Mvc;
using Models.Metadata;

namespace Models.DTO;

public class ImageDataDto
{
    public IFormFile? File { get; set; }
    
    [ModelBinder(BinderType = typeof(FormDataJsonBinder))]
    public ImageMetadata? ImageMetadata { get; set; } = new();
}