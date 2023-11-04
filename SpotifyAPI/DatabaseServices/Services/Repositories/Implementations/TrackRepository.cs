using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Repositories.Implementations;

public interface ITrackRepository
{
    public Task AddAsync(Track track);
    public Task<Track?> GetByIdAsync(string id);
    public IQueryable<Track> GetAll();
    public Task DeleteAsync(Track track);
    public Task UpdateAsync(Track track);
}

public class TrackRepository : Repository, ITrackRepository
{
    public TrackRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddAsync(Track track)
    {
        await DbContext.Tracks.AddAsync(track);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Track?> GetByIdAsync(string id)
    {
        return await GetAll()
            .FirstOrDefaultAsync(track => track.Id == id);
    }

    public IQueryable<Track> GetAll()
    {
        return DbContext.Tracks
            .Include(t => t.Album)
            .Include(t => t.Album.Author)
            .Include(t => t.Genres);
    }

    public async Task DeleteAsync(Track track)
    {
        DbContext.Tracks.Remove(track);
        await DbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Track track)
    {
        var toChange = (await GetByIdAsync(track.Id))!;
        toChange.Name = track.Name;
        await DbContext.SaveChangesAsync();
    }
}