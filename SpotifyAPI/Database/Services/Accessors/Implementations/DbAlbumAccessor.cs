using Database;
using Database.Services.Accessors;
using Database.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models;

public class DbAlbumAccessor:DbAccessor, IDbAlbumAccessor
{
    public DbAlbumAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }
    
    public async Task Add(Album album)
    {
        await DbContext.Albums.AddAsync(album);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Album?> Get(string id) =>
        await DbContext.Albums.Include(a=>a.Author).FirstOrDefaultAsync(a => a.Id == id);
}