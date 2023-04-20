using Database.Services.Accessors.Interfaces;
using Database.Services.EntityValidators.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class GenreFactory : IGenreFactory
{
    private IDbGenreAccessor _genreAccessor;
    private IGenreValidator _genreValidator;

    public GenreFactory(IDbGenreAccessor genreAccessor, IGenreValidator genreValidator)
    {
        _genreAccessor = genreAccessor;
        _genreValidator = genreValidator;
    }

    public async Task<(GenreValidationCode, Genre?)> Create(GenreCreationData data)
    {
        var validationResult = _genreValidator.Validate(data);
        return (validationResult.ValidationCode, validationResult.IsValid ? new Genre(data.Name) : null);
    }
}