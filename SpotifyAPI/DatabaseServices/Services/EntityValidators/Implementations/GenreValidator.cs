using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Implementations;

public class GenreValidator : EntityValidator, IGenreValidator
{
    private readonly IGenreRepository _genreRepository;

    public GenreValidator(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }

    public async Task<GenreValidationResult> Validate(GenreCreationData data)
    {
        var state = (GenreValidationCode)EntityValidator.Validate(data).ValidationCode;
        if (await _genreRepository.GetByNameAsync(data.Name) != null)
            state = GenreValidationCode.AlreadyExists;
        return new GenreValidationResult(state);
    }
}