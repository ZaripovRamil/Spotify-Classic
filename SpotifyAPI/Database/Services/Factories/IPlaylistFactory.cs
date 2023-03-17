using Models;
using Models.DTO;

namespace Database.Services.Factories;

public interface IPlaylistFactory
{
    public Task<Playlist?> Create(PlaylistCreationData pData);
}