using DatabaseServices.Services.Repositories.Implementations;
using Models.Entities;

namespace DatabaseServices.Services.QueryHandlers;

public interface IAuthorQueryHandler
{
    public List<Author> GetAll();
    public Task<Author?> GetById(string id);
    public Task<Author?> GetByName(string name);
}

public class AuthorQueryHandler : IAuthorQueryHandler
{
    private readonly IAuthorRepository _authorRepository;

    public AuthorQueryHandler(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public List<Author> GetAll()
    {
        return _authorRepository
            .GetAll().ToList();
    }

    public async Task<Author?> GetById(string id)
    {
        return await _authorRepository.GetByIdAsync(id);
    }

    public async Task<Author?> GetByName(string name)
    {
        return await _authorRepository.GetByNameAsync(name);
    }
}