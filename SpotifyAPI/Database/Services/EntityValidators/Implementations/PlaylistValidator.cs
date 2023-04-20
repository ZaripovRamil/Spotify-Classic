using Database.Services.EntityValidators.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace Database.Services.EntityValidators.Implementations;

public class PlaylistValidator :IPlaylistValidator
{
    public PlaylistValidationResult Validate(PlaylistCreationData data)
    {
        throw new NotImplementedException();
    }
}