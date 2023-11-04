using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Implementations;

public class PlaylistValidator : EntityValidator, IPlaylistValidator
{
    private readonly IUserRepository _userRepository;

    public PlaylistValidator(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<PlaylistValidationResult> Validate(PlaylistCreationData data)
    {
        var state = (PlaylistValidationCode)EntityValidator.Validate(data).ValidationCode;
        var user = await _userRepository.GetByIdAsync(data.OwnerId);
        if (user == null)
            state = PlaylistValidationCode.InvalidUser;
        return new PlaylistValidationResult(state, user);
    }
}