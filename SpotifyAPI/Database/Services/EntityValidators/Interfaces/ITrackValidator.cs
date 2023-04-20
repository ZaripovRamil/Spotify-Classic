using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace Database.Services.EntityValidators.Interfaces;

public interface ITrackValidator
{
    public TrackValidationResult Validate(TrackCreationData data);
}