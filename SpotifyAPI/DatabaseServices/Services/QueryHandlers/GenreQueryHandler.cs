using DatabaseServices.Services.Repositories.Implementations;
using Models.Entities;

namespace DatabaseServices.Services.QueryHandlers;

public interface IGenreQueryHandler
{
    public Task<Genre?> GetById(string id);
    public Task<Genre?> GetByName(string name);
}

public class GenreQueryHandler : IGenreQueryHandler
{
    private readonly IGenreRepository _genreRepository;

    public GenreQueryHandler(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }

    public Task<Genre?> GetById(string id)
    {
        return _genreRepository.GetById(id);
    }

    public Task<Genre?> GetByName(string name)
    {
        return _genreRepository.GetByName(name);
    }
}