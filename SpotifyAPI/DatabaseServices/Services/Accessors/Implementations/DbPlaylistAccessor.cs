using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Accessors.Implementations;

public class DbPlaylistAccessor : DbAccessor, IDbPlaylistAccessor
{
    public DbPlaylistAccessor(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task Add(Playlist playlist)
    {
        await DbContext.Playlists.AddAsync(playlist);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Playlist?> Get(string id) => await DbContext.Playlists
        .Include(p => p.Owner)
        .Include(p => p.Tracks)
        .ThenInclude(t => t.Album)
        .ThenInclude(a => a.Author)
        .Include(p => p.Tracks)
        .ThenInclude(t => t.Genres)
        .FirstOrDefaultAsync(p => p.Id == id);


    public async Task AddTrack(Playlist playlist, Track track)
    {
        playlist.Tracks ??= new List<Track>();
        playlist.Tracks.Add(track);
        await DbContext.SaveChangesAsync();
    }
}