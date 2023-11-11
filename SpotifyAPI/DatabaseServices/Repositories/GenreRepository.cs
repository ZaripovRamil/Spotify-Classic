using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Repositories;

public interface IGenreRepository : IUniqueNameEntityRepository<Genre>
{
}

public class GenreRepository : Repository, IGenreRepository
{
    public GenreRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Genre?> GetByIdAsync(string id) =>
        await GetAll().FirstOrDefaultAsync(g => g.Id == id);


    public async Task AddAsync(Genre genre)
    {
        await DbContext.Genres.AddAsync(genre);
        await DbContext.SaveChangesAsync();
    }

    public IQueryable<Genre> GetAll()
    {
        return DbContext.Genres;
    }

    public async Task DeleteAsync(Genre genre)
    {
        DbContext.Genres.Remove(genre);
        await DbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Genre genre)
    {
        var toChange = (await GetByIdAsync(genre.Id))!;
        toChange.Name = genre.Name;
        await DbContext.SaveChangesAsync();
    }

    public async Task<Genre?> GetByNameAsync(string name) =>
        await GetAll().FirstOrDefaultAsync(g => g.Name == name);
}