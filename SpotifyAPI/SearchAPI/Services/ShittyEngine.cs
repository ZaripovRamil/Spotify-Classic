using DatabaseServices.Services.Accessors.Interfaces;
using Models.DTO.BackToFront;
using Models.DTO.BackToFront.Light;

namespace SearchAPI.Services;

public class ShittyEngine : ISearchEngine
{
    private IDbTrackAccessor _trackAccessor;
    private IDbAlbumAccessor _albumAccessor;
    private IDbAuthorAccessor _authorAccessor;
    private IDbPlaylistAccessor _playlistAccessor;

    public ShittyEngine(IDbTrackAccessor trackAccessor, IDbAlbumAccessor albumAccessor,
        IDbAuthorAccessor authorAccessor, IDbPlaylistAccessor playlistAccessor)
    {
        _trackAccessor = trackAccessor;
        _albumAccessor = albumAccessor;
        _authorAccessor = authorAccessor;
        _playlistAccessor = playlistAccessor;
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
}