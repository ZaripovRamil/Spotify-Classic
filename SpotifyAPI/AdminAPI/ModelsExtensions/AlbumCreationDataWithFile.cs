using Models.DTO.FrontToBack.EntityCreationData;

namespace AdminAPI.ModelsExtensions;

public class AlbumCreationDataWithFile : AlbumCreationData
{
    public IFormFile PreviewFile { get; set; }
}