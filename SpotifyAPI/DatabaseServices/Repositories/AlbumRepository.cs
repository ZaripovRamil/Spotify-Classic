using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Repositories;

public interface IAlbumRepository : IRepository<Album>
{
    public IEnumerable<Album> GetWithFilters(string? albumType, int? tracksMin, int? tracksMax,
        int? maxCount, string? search);
}

public class AlbumRepository : Repository, IAlbumRepository
{
    public AlbumRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public async Task AddAsync(Album album)
    {
        await DbContext.Albums.AddAsync(album);
        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Album album)
    {
        DbContext.Albums.Remove(album);
        await DbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Album album)
    {
        DbContext.Albums.Update(album);
        await DbContext.SaveChangesAsync();
    }

    public IQueryable<Album> GetAll()
    {
        return DbContext.Albums.Include(a => a.Author)
            .Include(a => a.Tracks).AsNoTracking();
    }

    public IEnumerable<Album> GetWithFilters(string? albumType, int? tracksMin, int? tracksMax,
        int? maxCount, string? search)
    {
        return GetAll().AsEnumerable().Where(a =>
                (albumType == null ||
                 string.Equals(a.Type.ToString(), albumType, StringComparison.CurrentCultureIgnoreCase)) &&
                (tracksMin == null || a.Tracks.Count >= tracksMin.Value) &&
                (tracksMax == null || a.Tracks.Count <= tracksMax.Value) &&
                (search == null || a.Name.ToLower().Contains(search.ToLower())))
            .Take(maxCount ?? 100);
    }

    public async Task<Album?> GetByIdAsync(string id) =>
        await GetAll()
            .FirstOrDefaultAsync(a => a.Id == id);
}