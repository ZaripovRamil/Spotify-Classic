using Models;
using Models.Entities;

namespace Database.Services.Accessors.Interfaces;

public interface IDbAuthorAccessor
{
    public Task Add(Author author);
    public Task<Author?> Get(string id);
}