using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace Database.Services.EntityValidators.Implementations;

public class EntityValidator
{
    public EntityValidationResult Validate(EntityCreationData data)
    {
        var state = EntityValidationCode.Successful;
        if (data.Name == string.Empty)
            state = EntityValidationCode.EmptyName;
        if (data.Name
            .Any(c => !(char.IsDigit(c) || char.IsLetter(c) || char.IsWhiteSpace(c)|| char.IsPunctuation(c))))
            state = EntityValidationCode.InvalidName;
        return new EntityValidationResult((int)state);
    }
}