using DatabaseServices.Services.Repositories.Implementations;
using Models.Entities;

namespace DatabaseServices.Services.QueryHandlers;

public interface IAlbumQueryHandler
{
    public Task<Album?> GetById(string id);
    public Task<Album?> GetByName(string name);

    public Task<IEnumerable<Album>> GetWithFiltersAsync(string? albumType, int? tracksMin, int? tracksMax,
        int? maxCount, string? search);
}

public class AlbumQueryHandler : IAlbumQueryHandler
{
    private readonly IAlbumRepository _albumRepository;

    public AlbumQueryHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Album?> GetById(string id)
    {
        return await _albumRepository.GetByIdAsync(id);
    }

    public async Task<Album?> GetByName(string name)
    {
        return await _albumRepository.GetByNameAsync(name);
    }

    public Task<IEnumerable<Album>> GetWithFiltersAsync(string? albumType, int? tracksMin, int? tracksMax,
        int? maxCount, string? search)
    {
        return Task.FromResult(_albumRepository.GetAll().AsEnumerable().Where(a =>
                (albumType == null ||
                 string.Equals(a.Type.ToString(), albumType, StringComparison.CurrentCultureIgnoreCase)) &&
                (tracksMin == null || a.Tracks.Count >= tracksMin.Value) &&
                (tracksMax == null || a.Tracks.Count <= tracksMax.Value) &&
                (search == null || a.Name.ToLower().Contains(search.ToLower())))
            .Take(new Range(0, maxCount ?? ^1)));
    }
}