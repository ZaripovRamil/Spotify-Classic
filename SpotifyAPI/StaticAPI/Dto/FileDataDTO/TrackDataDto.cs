using Microsoft.AspNetCore.Mvc;
using Models.Metadata;
using Utils.Bind;

namespace StaticAPI.Dto.FileDataDTO;

public class TrackDataDto
{
    public IFormFile? File { get; set; }

    [ModelBinder(BinderType = typeof(FormDataJsonBinder))]
    public TrackMetadata? TrackMetadata { get; set; }
}