using DatabaseServices.Services.Accessors.Interfaces;
using Models.DTO.BackToFront;
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

    public async Task<UsersSearchResult> SearchUsersAsync(string query)
    {
        return new UsersSearchResult(_userAccessor.GetAllUsers()
            .Where(u => u.Name.ToLower().Contains(query.ToLower()) ||
                        u.NormalizedUserName is not null && u.NormalizedUserName.Contains(query.ToUpper()))
            .Select(u => new UserLight(u)).ToList());
    }

    public async Task<AlbumsSearchResult> SearchAlbumsAsync(string query)
    {
        return new AlbumsSearchResult(_albumAccessor.GetAll().Where(a =>
                a.Name.ToLower().Contains(query.ToLower()))
            .Select(a => new AlbumLight(a)).ToList());
    }
}