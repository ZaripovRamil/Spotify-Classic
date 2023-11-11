using Database;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace DatabaseServices.Repositories;

public interface IAlbumRepository : IUniqueNameEntityRepository<Album>
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
        var toChange = (await GetByIdAsync(album.Id))!;
        toChange.Name = album.Name;
        await DbContext.SaveChangesAsync();
    }

    public async Task<Album?> GetByNameAsync(string name) =>
        await GetAll()
            .FirstOrDefaultAsync(a => a.Name == name);

    public IQueryable<Album> GetAll()
    {
        return DbContext.Albums.Include(a => a.Author)
            .Include(a => a.Tracks);
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
            .Take(new Range(0, maxCount ?? ^1));
    }

    public async Task<Album?> GetByIdAsync(string id) =>
        await GetAll()
            .FirstOrDefaultAsync(a => a.Id == id);
}