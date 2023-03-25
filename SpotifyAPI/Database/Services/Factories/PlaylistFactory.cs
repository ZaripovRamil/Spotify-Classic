using Database.Services.Accessors;
using Models;
using Models.DTO;

namespace Database.Services.Factories;

public class PlaylistFactory:IPlaylistFactory
{
    private readonly IDbUserAccessor _userAccessor;

    public PlaylistFactory(IDbUserAccessor userAccessor)
    {
        _userAccessor = userAccessor;
    }

    public async Task<Playlist?> Create(PlaylistCreationData pData)
    {
        var owner = await _userAccessor.GetById(pData.OwnerId);
        return owner == null ? null : new Playlist(pData.Name, owner, pData.Type);
    }
}