using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class TrackFactory:ITrackFactory
{
    private readonly IDbAlbumAccessor _albumAccessor;
    private readonly IDbGenreAccessor _genreAccessor;
    private readonly IFileIdGenerator _idGenerator;

    public TrackFactory(IDbAlbumAccessor albumAccessor, IDbGenreAccessor genreAccessor, IFileIdGenerator idGenerator)
    {
        _albumAccessor = albumAccessor;
        _genreAccessor = genreAccessor;
        _idGenerator = idGenerator;
    }
    
    
    public async  Task<Track?> Create(TrackCreationData tData)
    {
        var album = await _albumAccessor.GetById(tData.AlbumId);
        if (album is null) return null;
        var genres = new List<Genre?>();
        foreach (var gId in tData.GenreIds)
            genres.Add( await _genreAccessor.GetById(gId));
        return genres.Any(genre => genre == null) ? null : new Track(tData.Name, album,_idGenerator.GetId(tData), genres.ToArray()!);
    }
}