using Database;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Accessors.Implementations;

public class DbAlbumAccessor : DbAccessor, IDbAlbumAccessor
{
    public DbAlbumAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task Add(Album album)
    {
        await DbContext.Albums.AddAsync(album);
        await DbContext.SaveChangesAsync();
    }

    public async Task Delete(Album album)
    {
        DbContext.Albums.Remove(album);
        await DbContext.SaveChangesAsync();
    }

    public async Task Update(Album album)
    {
        var toChange = (await GetById(album.Id))!;
        toChange.Name = album.Name;
        await DbContext.SaveChangesAsync();
    }

    public async Task<Album?> GetByName(string name) =>
        await GetAll()
            .FirstOrDefaultAsync(a => a.Name == name);

    public IQueryable<Album> GetAll()
    {
        return DbContext.Albums.Include(a => a.Author)
            .Include(a => a.Tracks);
    }

    public async Task<Album?> GetById(string id) =>
        await GetAll()
            .FirstOrDefaultAsync(a => a.Id == id);
}