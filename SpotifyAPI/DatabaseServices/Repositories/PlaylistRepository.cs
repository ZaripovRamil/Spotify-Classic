using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Entities.Joints;

namespace DatabaseServices.Repositories;

public interface IPlaylistRepository : IRepository<Playlist>
{
    Task AddTrackAsync(Playlist playlist, Track track);
    Task AddTracksAsync(string playlistId, List<string> trackIds);
    Task DeleteTracksAsync(string playlistId, List<string> trackIds);
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

    public async Task AddTracksAsync(string playlistId, List<string> trackIds)
    {
        foreach (var playlistTrack in trackIds.Select(trackId => new PlaylistTrack(playlistId, trackId)))
            await DbContext.PlaylistTracks.AddAsync(playlistTrack);

        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteTracksAsync(string playlistId, List<string> trackIds)
    {
        foreach (var playlistTrack in trackIds.Select(trackId => new PlaylistTrack(playlistId, trackId)))
            DbContext.PlaylistTracks.Remove(playlistTrack);

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
            .ThenInclude(t => t.Genres)
            .AsNoTracking();
    }

    public async Task DeleteAsync(Playlist playlist)
    {
        DbContext.Playlists.Remove(playlist);
        await DbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Playlist playlist)
    {
        DbContext.Playlists.Update(playlist);
        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteTrackAsync(Playlist playlist, Track track)
    {
        playlist.Tracks.Remove(track);
        await DbContext.SaveChangesAsync();
    }
}