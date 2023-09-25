using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.EntityValidators.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Implementations;

public class AuthorValidator:EntityValidator,IAuthorValidator
{
    private readonly IDbUserAccessor _userAccessor;

    public AuthorValidator(IDbUserAccessor userAccessor)
    {
        _userAccessor = userAccessor;
    }

    public async Task<AuthorValidationResult> Validate(AuthorCreationData data)
    {
        var state = (AuthorValidationCode) EntityValidator.Validate(data).ValidationCode;
        var user = await _userAccessor.GetById(data.UserId);
        if (user == null)
            state = AuthorValidationCode.InvalidUser;
        return new AuthorValidationResult(state, user);
    }
}