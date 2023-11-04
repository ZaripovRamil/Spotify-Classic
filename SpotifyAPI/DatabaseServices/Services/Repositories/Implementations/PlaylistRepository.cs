using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Repositories.Implementations;

public interface IPlaylistRepository
{
    public Task AddAsync(Playlist playlist);
    public Task<Playlist?> GetByIdAsync(string id);
    Task AddTrackAsync(Playlist playlist, Track track);
    IQueryable<Playlist> GetAll();
    Task DeleteAsync(Playlist playlist);
    Task UpdateAsync(Playlist playlist);
    Task DeleteTrackAsync(Playlist playlist, Track track);
}

public class PlaylistRepository : Repository, IPlaylistRepository
{
    public PlaylistRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddAsync(Playlist playlist)
    {
        await DbContext.Playlists.AddAsync(playlist);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Playlist?> GetByIdAsync(string id) => await GetAll()
        .FirstOrDefaultAsync(p => p.Id == id);


    public async Task AddTrackAsync(Playlist playlist, Track track)
    {
        playlist.Tracks.Add(track);
        await DbContext.SaveChangesAsync();
    }

    public IQueryable<Playlist> GetAll()
    {
        return DbContext.Playlists
            .Include(p => p.Owner)
            .Include(p => p.Tracks)
            .ThenInclude(t => t.Album)
            .ThenInclude(a => a.Author)
            .Include(p => p.Tracks)
            .ThenInclude(t => t.Genres);
    }

    public async Task DeleteAsync(Playlist playlist)
    {
        DbContext.Playlists.Remove(playlist);
        await DbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Playlist playlist)
    {
        var toChange = (await GetByIdAsync(playlist.Id))!;
        toChange.Name = playlist.Name;
        toChange.PreviewId = playlist.PreviewId;
        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteTrackAsync(Playlist playlist, Track track)
    {
        playlist.Tracks.Remove(track);
        await DbContext.SaveChangesAsync();
    }
}