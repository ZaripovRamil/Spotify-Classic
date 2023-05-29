using Models.Entities;

namespace DatabaseServices.Services.Accessors.Interfaces;

public interface IDbAuthorAccessor
{
    Task Add(Author author);
    Task<Author?> GetById(string id);
    Task<Author?> GetByName(string name);
    IQueryable<Author> GetAll();
    Task Delete(Author author);
    Task Update(Author author);
}