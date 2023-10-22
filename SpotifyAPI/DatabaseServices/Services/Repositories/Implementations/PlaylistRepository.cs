using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Repositories.Implementations;

public interface IPlaylistRepository
{
    public Task Add(Playlist playlist);
    public Task<Playlist?> Get(string id);
    Task AddTrack(Playlist playlist, Track track);
    IQueryable<Playlist> GetAll();
    Task Delete(Playlist playlist);
    Task Update(Playlist playlist);
    Task DeleteTrack(Playlist playlist, Track track);
}

public class PlaylistRepository : Repository, IPlaylistRepository
{
    public PlaylistRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task Add(Playlist playlist)
    {
        await DbContext.Playlists.AddAsync(playlist);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Playlist?> Get(string id) => await GetAll()
        .FirstOrDefaultAsync(p => p.Id == id);


    public async Task AddTrack(Playlist playlist, Track track)
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

    public async Task Delete(Playlist playlist)
    {
        DbContext.Playlists.Remove(playlist);
        await DbContext.SaveChangesAsync();
    }

    public async Task Update(Playlist playlist)
    {
        var toChange = (await Get(playlist.Id))!;
        toChange.Name = playlist.Name;
        toChange.PreviewId = playlist.PreviewId;
        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteTrack(Playlist playlist, Track track)
    {
        playlist.Tracks.Remove(track);
        await DbContext.SaveChangesAsync();
    }
}