using Database.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Database.Services.Accessors.Implementations;

public class DbGenreAccessor:DbAccessor, IDbGenreAccessor
{
    public DbGenreAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Genre?> GetById(string id) =>
        await DbContext.Genres.FirstOrDefaultAsync(g => g.Id == id);
    

    public async Task Add(Genre genre)
    {
        await DbContext.Genres.AddAsync(genre);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Genre?> GetByName(string name) =>
        await DbContext.Genres.FirstOrDefaultAsync(g => g.Name == name);
}