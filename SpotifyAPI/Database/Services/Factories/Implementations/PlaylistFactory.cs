using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models;
using Models.DTO;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Services.Factories.Implementations;

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
        return owner == null ? null : new Playlist(pData.Name, owner);
    }
}