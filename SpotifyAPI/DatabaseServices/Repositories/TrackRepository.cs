using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Repositories;

public interface ITrackRepository : IRepository<Track>
{
    public List<Track> GetWithFiltersAsync(int? pageSize, int? pageIndex, string? query);
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

    public List<Track> GetWithFiltersAsync(int? pageSize, int? pageIndex, string? query)
    {
        return GetAll().AsEnumerable().Where(t =>
                query == null || t.Name.ToLower().Contains(query.ToLower()))
            .Take(new Range((pageSize ?? 20) * ((pageIndex ?? 1) - 1), (pageIndex ?? 1) * (pageSize ?? 20)))
            .ToList();
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