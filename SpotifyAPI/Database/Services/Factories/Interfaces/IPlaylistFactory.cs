using Models;
using Models.DTO;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Services.Factories.Interfaces;

public interface IPlaylistFactory
{
    public Task<Playlist?> Create(PlaylistCreationData pData);
}