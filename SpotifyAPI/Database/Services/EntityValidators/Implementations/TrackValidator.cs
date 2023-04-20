using Database.Services.EntityValidators.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.ValidationResult;

namespace Database.Services.EntityValidators.Implementations;

public class TrackValidator:ITrackValidator
{
    public TrackValidationResult Validate(TrackCreationData data)
    {
        throw new NotImplementedException();
    }
}