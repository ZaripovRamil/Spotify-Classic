using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.EntityValidators.Implementations;

public class EntityValidator
{
    protected EntityValidator()
    {
    }

    protected static EntityValidationResult Validate(EntityCreationData data)
    {
        var state = EntityValidationCode.Successful;
        if (data.Name == string.Empty)
            state = EntityValidationCode.EmptyName;
        if (data.Name
            .Any(c => !(char.IsDigit(c) || char.IsLetter(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c))))
            state = EntityValidationCode.InvalidName;
        return new EntityValidationResult((int)state);
    }
}