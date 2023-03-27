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
    
    public async Task<Album?> GetByName(string name)=>
        await DbContext.Albums
            .Include(a=>a.Author)
            .Include(a=>a.Tracks)
            .FirstOrDefaultAsync(a => a.Name == name);
    

    public async Task<Album?> GetById(string id) =>
        await DbContext.Albums
            .Include(a=>a.Author)
            .Include(a=>a.Tracks)
            .FirstOrDefaultAsync(a => a.Id == id);
}