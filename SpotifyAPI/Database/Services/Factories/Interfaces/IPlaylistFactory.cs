using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface IPlaylistFactory
{
    public Task<Playlist?> Create(PlaylistCreationData pData);
}