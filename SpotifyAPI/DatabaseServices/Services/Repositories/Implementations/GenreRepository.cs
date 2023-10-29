using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Repositories.Implementations;

public interface IGenreRepository
{
    public Task<Genre?> GetByIdAsync(string id);
    public Task AddAsync(Genre genre);
    public IQueryable<Genre> GetAll();
    Task<Genre?> GetByNameAsync(string genreName);
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

    public async Task<Genre?> GetByNameAsync(string genreName) =>
        await GetAll().FirstOrDefaultAsync(g => g.Name == genreName);
}