using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Interfaces;

public interface ITrackValidator
{
    public Task<TrackValidationResult> Validate(TrackCreationData data);
}