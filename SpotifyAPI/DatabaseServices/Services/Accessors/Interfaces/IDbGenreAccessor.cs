using Models.Entities;

namespace DatabaseServices.Services.Accessors.Interfaces;

public interface IDbGenreAccessor
{
    public Task<Genre?> GetById(string id);
    public Task Add(Genre genre);
    public IQueryable<Genre> GetAll();
    Task<Genre?> GetByName(string gDataName);
}