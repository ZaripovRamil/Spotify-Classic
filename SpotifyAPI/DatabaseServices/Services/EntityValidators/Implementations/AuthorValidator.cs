using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Implementations;

public class AuthorValidator : EntityValidator, IAuthorValidator
{
    private readonly IUserRepository _userRepository;

    public AuthorValidator(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<AuthorValidationResult> Validate(AuthorCreationData data)
    {
        var state = (AuthorValidationCode)EntityValidator.Validate(data).ValidationCode;
        var user = await _userRepository.GetByIdAsync(data.UserId);
        if (user == null)
            state = AuthorValidationCode.InvalidUser;
        return new AuthorValidationResult(state, user);
    }
}