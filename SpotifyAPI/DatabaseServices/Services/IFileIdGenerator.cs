using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services;

public interface IFileIdGenerator
{
    public string GetId(TrackCreationData trackCreationData);
    public string GetId(AlbumCreationData trackCreationData);
    string GetId(PlaylistCreationData trackCreationData);
}