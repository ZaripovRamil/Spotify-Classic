using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class PlaylistFactory:IPlaylistFactory
{
    private readonly IDbUserAccessor _userAccessor;
    private readonly IFileIdGenerator _idGenerator;

    public PlaylistFactory(IDbUserAccessor userAccessor, IFileIdGenerator idGenerator)
    {
        _userAccessor = userAccessor;
        _idGenerator = idGenerator;
    }

    public async Task<Playlist?> Create(PlaylistCreationData pData)
    {
        var owner = await _userAccessor.GetById(pData.OwnerId);
        return owner == null ? null : new Playlist(pData.Name, owner);
    }
}