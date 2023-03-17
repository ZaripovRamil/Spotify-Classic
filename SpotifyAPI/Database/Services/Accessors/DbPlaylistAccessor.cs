using Models;

namespace Database.Controllers.Accessors;

public class DbPlaylistAccessor:DbAccessor, IDbPlaylistAccessor
{
    public DbPlaylistAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }
    
    public async Task AddPlaylist(Playlist playlist)
    {
        await DbContext.Playlists.AddAsync(playlist);
        await DbContext.SaveChangesAsync();
    }

    
}