using DatabaseServices.EntityValidators.Interfaces;
using DatabaseServices.Repositories;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.CommandHandlers.CreateHandlers;

public interface IPlaylistCreateHandler
{
    public Task<PlaylistCreationResult> Create(PlaylistCreationData data);
}

public class PlaylistCreateHandler : IPlaylistCreateHandler
{
    private readonly IPlaylistRepository _playlistRepository;
    private readonly IPlaylistValidator _playlistValidator;

    public PlaylistCreateHandler(IPlaylistValidator playlistValidator, IPlaylistRepository playlistRepository)
    {
        _playlistValidator = playlistValidator;
        _playlistRepository = playlistRepository;
    }

    public async Task<PlaylistCreationResult> Create(PlaylistCreationData data)
    {
        var validationResult = await _playlistValidator.Validate(data);
        var playlist = validationResult.IsValid ? new Playlist(data.Name, validationResult.Owner!) : null;
        if (playlist != null)
            await _playlistRepository.AddAsync(playlist);
        return new PlaylistCreationResult((PlaylistValidationCode)validationResult.ValidationCode,
            playlist);
    }
}