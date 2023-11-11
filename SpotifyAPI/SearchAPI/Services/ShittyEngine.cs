using DatabaseServices.Repositories;
using Models.DTO.BackToFront;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;

namespace SearchAPI.Services;

public class ShittyEngine : ISearchEngine
{
    private readonly ITrackRepository _trackRepository;
    private readonly IAlbumRepository _albumRepository;
    private readonly IAuthorRepository _authorRepository;
    private readonly IPlaylistRepository _playlistRepository;
    private readonly IUserRepository _userRepository;

    public ShittyEngine(ITrackRepository trackRepository, IAlbumRepository albumRepository,
        IAuthorRepository authorRepository, IPlaylistRepository playlistRepository, IUserRepository userRepository)
    {
        _trackRepository = trackRepository;
        _albumRepository = albumRepository;
        _authorRepository = authorRepository;
        _playlistRepository = playlistRepository;
        _userRepository = userRepository;
    }

    public Task<SearchResult> SearchAsync(string query)
    {
        return Task.FromResult(new SearchResult(
            _trackRepository.GetAll().Where(t => t.Name.ToLower().Contains(query.ToLower()))
                .Select(t => new TrackLight(t)).Take(10).ToList(),
            _albumRepository.GetAll().Where(t => t.Name.ToLower().Contains(query.ToLower()))
                .Select(t => new AlbumLight(t)).Take(10).ToList(),
            _authorRepository.GetAll().Where(t => t.Name.ToLower().Contains(query.ToLower()))
                .Select(t => new AuthorLight(t)).Take(10)
                .ToList(),
            _playlistRepository.GetAll().Where(t => t.Name.ToLower().Contains(query.ToLower()))
                .Select(t => new PlaylistLight(t)).Take(10)
                .ToList()));
    }

    public Task<UsersSearchResult> SearchUsersAsync(string query)
    {
        return Task.FromResult(new UsersSearchResult(_userRepository.GetAll()
            .Where(u => u.Name.ToLower().Contains(query.ToLower()) ||
                        u.NormalizedUserName != null && u.NormalizedUserName.Contains(query.ToUpper()))
            .Select(u => new UserLight(u)).ToList()));
    }

    public Task<AlbumsSearchResult> SearchAlbumsAsync(string query)
    {
        return Task.FromResult(new AlbumsSearchResult(_albumRepository.GetAll().Where(a =>
                a.Name.ToLower().Contains(query.ToLower()))
            .Select(a => new AlbumLight(a)).ToList()));
    }

    public Task<IEnumerable<AlbumFull>> SearchAlbumsByAuthorsAsync(string query)
    {
        return Task.FromResult<IEnumerable<AlbumFull>>(_albumRepository.GetAll().Where(a =>
                a.Author.Name.ToLower().Contains(query.ToLower()))
            .Select(a => new AlbumFull(a)));
    }

    public Task<IEnumerable<AuthorFull>> SearchAuthorsByUserAsync(string query)
    {
        return Task.FromResult<IEnumerable<AuthorFull>>(_authorRepository.GetAll().Where(a =>
                a.User.Name.ToLower().Contains(query.ToLower()) || a.User.NormalizedUserName != null &&
                a.User.NormalizedUserName.Contains(query.ToUpper()))
            .Select(a => new AuthorFull(a)));
    }

    public Task<IEnumerable<TrackFull>> SearchTracksByAlbumOrAuthorAsync(string query)
    {
        return Task.FromResult<IEnumerable<TrackFull>>(_trackRepository.GetAll().Where(t =>
                t.Album.Name.ToLower().Contains(query.ToLower()) ||
                t.Album.Author.Name.ToLower().Contains(query.ToLower()))
            .Select(t => new TrackFull(t)));
    }
}