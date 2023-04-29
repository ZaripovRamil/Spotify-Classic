using Models.Entities;

namespace DatabaseServices.Services.Accessors.Interfaces;

public interface IDbAuthorAccessor
{
    public Task Add(Author author);
    Task<Author?> GetById(string id);
    Task<Author?> GetByName(string name);
    public IEnumerable<Author> GetAll();
}