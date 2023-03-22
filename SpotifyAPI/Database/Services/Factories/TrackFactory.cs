using Database.Services.Accessors;
using Models;
using Models.DTO;

namespace Database.Services.Factories;

public class TrackFactory:ITrackFactory
{
    private readonly IDbPlaylistAccessor _playlistAccessor;
    private readonly IDbGenreAccessor _genreAccessor;

    public TrackFactory(IDbPlaylistAccessor playlistAccessor, IDbGenreAccessor genreAccessor)
    {
        _playlistAccessor = playlistAccessor;
        _genreAccessor = genreAccessor;
    }
    
    
    public async  Task<Track?> Create(TrackCreationData tData)
    {
        var album = await _playlistAccessor.Get(tData.AlbumId);
        if (album is not {Type: PlaylistType.Album}) return null;
        var genres = new List<Genre?>();
        foreach (var gId in tData.GenreIds)
            genres.Add( await _genreAccessor.GetById(gId));
        return genres.Any(genre => genre == null) ? null : new Track(tData.Name, album, genres);
    }
}