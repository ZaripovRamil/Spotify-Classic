using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Services;

public class FileIdGenerator:IFileIdGenerator
{
    public string GetId(TrackCreationData trackCreationData)
    {
        return Guid.NewGuid().ToString();
    }

    public string GetId(AlbumCreationData trackCreationData)
    {
        return Guid.NewGuid().ToString();
    }

    public string GetId(PlaylistCreationData trackCreationData)
    {
        return Guid.NewGuid().ToString();
    }
}