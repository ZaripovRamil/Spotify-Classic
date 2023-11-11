using Models.DTO.FrontToBack.EntityCreationData;

namespace DatabaseServices;

public interface IFileIdGenerator
{
    public string GetId(TrackCreationData trackCreationData);
    public string GetId(AlbumCreationData trackCreationData);
    string GetId(PlaylistCreationData trackCreationData);
}