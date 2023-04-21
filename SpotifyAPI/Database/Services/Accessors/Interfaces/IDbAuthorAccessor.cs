using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Database.Services.Accessors.Interfaces;

public interface IDbAuthorAccessor
{
    public Task Add(Author author);
    Task<Author?> GetById(string id);
    Task<Author?> GetByName(string name);
    IEnumerable<Author> GetAll();
}