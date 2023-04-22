using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.Services.Factories.Implementations;

public class PlaylistFactory : IPlaylistFactory
{
    private readonly IFileIdGenerator _idGenerator;
    private readonly IPlaylistValidator _playlistValidator;

    public PlaylistFactory(IFileIdGenerator idGenerator,
        IPlaylistValidator playlistValidator)
    {
        _idGenerator = idGenerator;
        _playlistValidator = playlistValidator;
    }

    public async Task<(PlaylistValidationCode, Playlist?)> Create(PlaylistCreationData data)
    {
        var validationResult = await _playlistValidator.Validate(data);
        return ((PlaylistValidationCode)validationResult.ValidationCode,
            validationResult.IsValid ? new Playlist(data.Name, validationResult.Owner) : null);
    }
}