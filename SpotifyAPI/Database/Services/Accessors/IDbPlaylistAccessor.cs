using Models;

namespace Database.Controllers.Accessors;

public interface IDbPlaylistAccessor
{
    public Task AddPlaylist(Playlist? playlist);
}