using Microsoft.AspNetCore.Mvc;
using Models.Metadata;

namespace Models.DTO.FileDataDTO;

public class TrackDataDto
{
    public IFormFile? File { get; set; }
    
    [ModelBinder(BinderType = typeof(FormDataJsonBinder))]
    public TrackMetadata? TrackMetadata { get; set; }
}