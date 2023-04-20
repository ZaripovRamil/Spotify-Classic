using Database.Services.Accessors.Interfaces;
using Database.Services.EntityValidators.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class PlaylistFactory : IPlaylistFactory
{
    private readonly IDbUserAccessor _userAccessor;
    private readonly IFileIdGenerator _idGenerator;
    private readonly IPlaylistValidator _playlistValidator;

    public PlaylistFactory(IDbUserAccessor userAccessor, IFileIdGenerator idGenerator,
        IPlaylistValidator playlistValidator)
    {
        _userAccessor = userAccessor;
        _idGenerator = idGenerator;
        _playlistValidator = playlistValidator;
    }

    public async Task<(PlaylistValidationCode, Playlist?)> Create(PlaylistCreationData data)
    {
        var validationResult = _playlistValidator.Validate(data);
        return (validationResult.ValidationCode,
            validationResult.IsValid ? new Playlist(data.Name, validationResult.Owner) : null);
    }
}