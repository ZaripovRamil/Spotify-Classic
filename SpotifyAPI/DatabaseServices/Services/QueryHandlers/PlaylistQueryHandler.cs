using DatabaseServices.Services.Repositories.Implementations;
using Models.Entities;

namespace DatabaseServices.Services.QueryHandlers;

public interface IPlaylistQueryHandler
{
    public List<Playlist> GetAll();
    public Task<Playlist?> GetById(string id);
}

public class PlaylistQueryHandler : IPlaylistQueryHandler
{
    private readonly IPlaylistRepository _playlistRepository;

    public PlaylistQueryHandler(IPlaylistRepository playlistRepository)
    {
        _playlistRepository = playlistRepository;
    }

    public List<Playlist> GetAll()
    {
        return _playlistRepository.GetAll().ToList();
    }

    public async Task<Playlist?> GetById(string id)
    {
        return await _playlistRepository.Get(id);
    }
}