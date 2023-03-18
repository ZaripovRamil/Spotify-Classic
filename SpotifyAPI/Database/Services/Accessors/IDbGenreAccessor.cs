using Models;
using Models.DTO;

namespace Database.Services.Accessors;

public interface IDbGenreAccessor
{
    public Task<Genre?> GetById(string id);
    public Task Add(Genre genre);
    Task<Genre?> GetByName(string gDataName);
}

