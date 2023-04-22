using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.Services.Factories.Implementations;

public class GenreFactory : IGenreFactory
{
    private IGenreValidator _genreValidator;

    public GenreFactory(IGenreValidator genreValidator)
    {
        _genreValidator = genreValidator;
    }

    public async Task<(GenreValidationCode, Genre?)> Create(GenreCreationData data)
    {
        var validationResult = await _genreValidator.Validate(data);
        return ((GenreValidationCode)validationResult.ValidationCode, validationResult.IsValid ? new Genre(data.Name) : null);
    }
}