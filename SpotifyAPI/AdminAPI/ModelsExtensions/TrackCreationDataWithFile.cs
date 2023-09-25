using Models.DTO.FrontToBack.EntityCreationData;

namespace AdminAPI.ModelsExtensions;

public class TrackCreationDataWithFile : TrackCreationData
{
    public IFormFile TrackFile { get; set; } = default!;
}