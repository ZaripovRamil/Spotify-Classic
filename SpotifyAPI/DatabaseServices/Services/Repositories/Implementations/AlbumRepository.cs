using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Repositories.Implementations;

public interface IAlbumRepository
{
    public Task AddAsync(Album album);
    Task<Album?> GetByIdAsync(string id);
    Task<Album?> GetByNameAsync(string name);
    IQueryable<Album> GetAll();
    Task DeleteAsync(Album album);
    Task UpdateAsync(Album album);
}

public class AlbumRepository : Repository, IAlbumRepository
{
    public AlbumRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddAsync(Album album)
    {
        await DbContext.Albums.AddAsync(album);
        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Album album)
    {
        DbContext.Albums.Remove(album);
        await DbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Album album)
    {
        var toChange = (await GetByIdAsync(album.Id))!;
        toChange.Name = album.Name;
        await DbContext.SaveChangesAsync();
    }

    public async Task<Album?> GetByNameAsync(string name) =>
        await GetAll()
            .FirstOrDefaultAsync(a => a.Name == name);

    public IQueryable<Album> GetAll()
    {
        return DbContext.Albums.Include(a => a.Author)
            .Include(a => a.Tracks);
    }

    public async Task<Album?> GetByIdAsync(string id) =>
        await GetAll()
            .FirstOrDefaultAsync(a => a.Id == id);
}