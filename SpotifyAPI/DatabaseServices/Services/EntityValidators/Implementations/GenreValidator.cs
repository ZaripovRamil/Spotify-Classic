using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.EntityValidators.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Implementations;

public class GenreValidator:EntityValidator,IGenreValidator
{
    private readonly IDbGenreAccessor _genreAccessor;

    public GenreValidator(IDbGenreAccessor genreAccessor)
    {
        _genreAccessor = genreAccessor;
    }

    public async Task<GenreValidationResult> Validate(GenreCreationData data)
    {
        var state = (GenreValidationCode) base.Validate(data).ValidationCode;
        if (await _genreAccessor.GetByName(data.Name) != null)
            state = GenreValidationCode.AlreadyExists;
        return new GenreValidationResult(state);
    }
}