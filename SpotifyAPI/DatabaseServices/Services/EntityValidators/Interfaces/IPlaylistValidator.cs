using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Interfaces;

public interface IPlaylistValidator
{
    public Task<PlaylistValidationResult> Validate(PlaylistCreationData data);
}