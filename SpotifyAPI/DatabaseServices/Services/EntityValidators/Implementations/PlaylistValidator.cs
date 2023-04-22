using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.EntityValidators.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Implementations;

public class PlaylistValidator :EntityValidator,IPlaylistValidator
{
    private readonly IDbUserAccessor _userAccessor;

    public PlaylistValidator(IDbUserAccessor userAccessor)
    {
        _userAccessor = userAccessor;
    }

    public async Task<PlaylistValidationResult> Validate(PlaylistCreationData data)
    {
        var state = (PlaylistValidationCode) base.Validate(data).ValidationCode;
        var user = await _userAccessor.GetById(data.OwnerId);
        if (user == null)
            state = PlaylistValidationCode.InvalidUser;
        return new PlaylistValidationResult(state, user);
    }
}