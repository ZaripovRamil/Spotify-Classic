using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class GenreFactory : IGenreFactory
{
    private IDbGenreAccessor _genreAccessor;

    public GenreFactory(IDbGenreAccessor genreAccessor)
    {
        _genreAccessor = genreAccessor;
    }

    public async Task<(GenreCreationCode, Genre?)> Create(GenreCreationData data)
    {
        return await _genreAccessor.GetByName(data.Name) != null
            ? (GenreCreationCode.AlreadyExists, null)
            : (GenreCreationCode.Successful, new Genre(data.Name));
    }
}