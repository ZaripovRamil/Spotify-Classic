using Models.DTO.FrontToBack.EntityCreationData;

namespace DatabaseServices;

public class FileIdGenerator : IFileIdGenerator
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