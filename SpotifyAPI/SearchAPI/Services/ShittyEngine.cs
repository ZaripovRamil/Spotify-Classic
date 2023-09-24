using DatabaseServices.Services.Accessors.Interfaces;
using Models.DTO.BackToFront;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;

namespace SearchAPI.Services;

public class ShittyEngine : ISearchEngine
{
    private readonly IDbTrackAccessor _trackAccessor;
    private readonly IDbAlbumAccessor _albumAccessor;
    private readonly IDbAuthorAccessor _authorAccessor;
    private readonly IDbPlaylistAccessor _playlistAccessor;
    private readonly IDbUserAccessor _userAccessor;

    public ShittyEngine(IDbTrackAccessor trackAccessor, IDbAlbumAccessor albumAccessor,
        IDbAuthorAccessor authorAccessor, IDbPlaylistAccessor playlistAccessor, IDbUserAccessor userAccessor)
    {
        _trackAccessor = trackAccessor;
        _albumAccessor = albumAccessor;
        _authorAccessor = authorAccessor;
        _playlistAccessor = playlistAccessor;
        _userAccessor = userAccessor;
    }

    public Task<SearchResult> SearchAsync(string query)
    {
        return Task.FromResult(new SearchResult(
            _trackAccessor.GetAll().Where(t => t.Name.ToLower().Contains(query.ToLower()))
                .Select(t => new TrackLight(t)).Take(10).ToList(),
            _albumAccessor.GetAll().Where(t => t.Name.ToLower().Contains(query.ToLower()))
                .Select(t => new AlbumLight(t)).Take(10).ToList(),
            _authorAccessor.GetAll().Where(t => t.Name.ToLower().Contains(query.ToLower()))
                .Select(t => new AuthorLight(t)).Take(10)
                .ToList(),
            _playlistAccessor.GetAll().Where(t => t.Name.ToLower().Contains(query.ToLower()))
                .Select(t => new PlaylistLight(t)).Take(10)
                .ToList()));
    }

    public Task<UsersSearchResult> SearchUsersAsync(string query)
    {
        return Task.FromResult(new UsersSearchResult(_userAccessor.GetAllUsers()
            .Where(u => u.Name.ToLower().Contains(query.ToLower()) ||
                        u.NormalizedUserName is not null && u.NormalizedUserName.Contains(query.ToUpper()))
            .Select(u => new UserLight(u)).ToList()));
    }

    public Task<AlbumsSearchResult> SearchAlbumsAsync(string query)
    {
        return Task.FromResult(new AlbumsSearchResult(_albumAccessor.GetAll().Where(a =>
                a.Name.ToLower().Contains(query.ToLower()))
            .Select(a => new AlbumLight(a)).ToList()));
    }

    public Task<IEnumerable<AlbumFull>> SearchAlbumsByAuthorsAsync(string query)
    {
        return Task.FromResult<IEnumerable<AlbumFull>>(_albumAccessor.GetAll().Where(a =>
                a.Author.Name.ToLower().Contains(query.ToLower()))
            .Select(a => new AlbumFull(a)));
    }

    public Task<IEnumerable<AuthorFull>> SearchAuthorsByUserAsync(string query)
    {
        return Task.FromResult<IEnumerable<AuthorFull>>(_authorAccessor.GetAll().Where(a =>
                a.User.Name.ToLower().Contains(query.ToLower()) || a.User.NormalizedUserName != null &&
                a.User.NormalizedUserName.Contains(query.ToUpper()))
            .Select(a => new AuthorFull(a)));
    }

    public Task<IEnumerable<TrackFull>> SearchTracksByAlbumOrAuthorAsync(string query)
    {
        return Task.FromResult<IEnumerable<TrackFull>>(_trackAccessor.GetAll().Where(t =>
                t.Album.Name.ToLower().Contains(query.ToLower()) ||
                t.Album.Author.Name.ToLower().Contains(query.ToLower()))
            .Select(t => new TrackFull(t)));
    }
}