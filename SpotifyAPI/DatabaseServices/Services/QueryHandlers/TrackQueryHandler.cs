using DatabaseServices.Services.Repositories.Implementations;
using Models.Entities;

namespace DatabaseServices.Services.QueryHandlers;

public interface ITrackQueryHandler
{
    public Task<Track?> GetById(string id);
    public List<Track> GetWithFiltersAsync(int? pageSize, int? pageIndex, string? query);
}

public class TrackQueryHandler : ITrackQueryHandler
{
    private readonly ITrackRepository _trackRepository;

    public TrackQueryHandler(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
    }

    public async Task<Track?> GetById(string id)
    {
        return await _trackRepository.Get(id);
    }

    public List<Track> GetWithFiltersAsync(int? pageSize, int? pageIndex, string? query)
    {
        return _trackRepository.GetAll().AsEnumerable().Where(t =>
                query == null || t.Name.ToLower().Contains(query.ToLower()))
            .Take(new Range((pageSize ?? 20) * ((pageIndex ?? 1) - 1), (pageIndex ?? 1) * (pageSize ?? 20)))
            .ToList();
    }
}