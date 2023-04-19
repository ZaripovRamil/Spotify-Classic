using Database.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Database.Services.Accessors.Implementations;

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
    
    public async Task<Album?> GetByName(string name)=>
        await DbContext.Albums
            .Include(a=>a.Author)
            .Include(a=>a.Tracks)
            .FirstOrDefaultAsync(a => a.Name == name);

    public IEnumerable<Album> GetAll() => DbContext.Albums.Include(a => a.Author);


    public async Task<Album?> GetById(string id) =>
        await DbContext.Albums
            .Include(a=>a.Author)
            .Include(a=>a.Tracks)
            .FirstOrDefaultAsync(a => a.Id == id);
}