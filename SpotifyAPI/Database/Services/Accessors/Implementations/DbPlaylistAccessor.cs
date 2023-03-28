using Database.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Database.Services.Accessors.Implementations;

public class DbPlaylistAccessor:DbAccessor, IDbPlaylistAccessor
{
    public DbPlaylistAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }
    
    public async Task Add(Playlist playlist)
    {
        await DbContext.Playlists.AddAsync(playlist);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Playlist?> Get(string id) =>
        await DbContext.Playlists.FirstOrDefaultAsync(p => p.Id == id);
}