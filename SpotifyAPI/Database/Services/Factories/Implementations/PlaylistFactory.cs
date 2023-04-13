using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class PlaylistFactory : IPlaylistFactory
{
    private readonly IDbUserAccessor _userAccessor;
    private readonly IFileIdGenerator _idGenerator;

    public PlaylistFactory(IDbUserAccessor userAccessor, IFileIdGenerator idGenerator)
    {
        _userAccessor = userAccessor;
        _idGenerator = idGenerator;
    }

    public async Task<(PlaylistCreationCode, Playlist?)> Create(PlaylistCreationData data)
    {
        var owner = await _userAccessor.GetById(data.OwnerId);
        if (owner == null) return (PlaylistCreationCode.InvalidUser, null);
        return (PlaylistCreationCode.Successful, new Playlist(data.Name, owner));
    }
}