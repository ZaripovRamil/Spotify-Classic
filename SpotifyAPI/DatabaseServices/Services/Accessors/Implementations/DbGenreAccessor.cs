using Database;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Accessors.Implementations;

public class DbGenreAccessor : DbAccessor, IDbGenreAccessor
{
    public DbGenreAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Genre?> GetById(string id) =>
        await GetAll().FirstOrDefaultAsync(g => g.Id == id);


    public async Task Add(Genre genre)
    {
        await DbContext.Genres.AddAsync(genre);
        await DbContext.SaveChangesAsync();
    }

    public IQueryable<Genre> GetAll()
    {
        return DbContext.Genres;
    }

    public async Task<Genre?> GetByName(string genreName) =>
        await GetAll().FirstOrDefaultAsync(g => g.Name == genreName);
}