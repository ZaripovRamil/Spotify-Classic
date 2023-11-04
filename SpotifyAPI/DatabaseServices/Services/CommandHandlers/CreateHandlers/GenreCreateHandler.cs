using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.Services.CommandHandlers.CreateHandlers;

public interface IGenreCreateHandler
{
    public Task<GenreCreationResult> Create(GenreCreationData data);
}

public class GenreCreateHandler : IGenreCreateHandler
{
    private readonly IGenreRepository _genreRepository;
    private readonly IGenreValidator _genreValidator;

    public GenreCreateHandler(IGenreValidator genreValidator, IGenreRepository genreRepository)
    {
        _genreValidator = genreValidator;
        _genreRepository = genreRepository;
    }

    public async Task<GenreCreationResult> Create(GenreCreationData data)
    {
        var validationResult = await _genreValidator.Validate(data);
        var genre = validationResult.IsValid ? new Genre(data.Name) : null;
        if (genre != null)
            await _genreRepository.AddAsync(genre);
        return new GenreCreationResult((GenreValidationCode)validationResult.ValidationCode, genre);
    }
}