using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Services.Repositories.Implementations;

public interface ITrackRepository
{
    public Task Add(Track track);
    public Task<Track?> Get(string id);
    public IQueryable<Track> GetAll();
    public Task Delete(Track track);
    public Task Update(Track track);
}

public class TrackRepository : Repository, ITrackRepository
{
    public TrackRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task Add(Track track)
    {
        await DbContext.Tracks.AddAsync(track);
        await DbContext.SaveChangesAsync();
    }

    public async Task<Track?> Get(string id)
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

    public async Task Delete(Track track)
    {
        DbContext.Tracks.Remove(track);
        await DbContext.SaveChangesAsync();
    }

    public async Task Update(Track track)
    {
        var toChange = (await Get(track.Id))!;
        toChange.Name = track.Name;
        await DbContext.SaveChangesAsync();
    }
}