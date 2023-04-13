using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class TrackFactory : ITrackFactory
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


    public async Task<(TrackCreationCode, Track?)> Create(TrackCreationData data)
    {
        var album = await _albumAccessor.GetById(data.AlbumId);
        if (album is null) return (TrackCreationCode.InvalidAlbum, null);
        var genres = new List<Genre?>();
        foreach (var gId in data.GenreIds)
            genres.Add(await _genreAccessor.GetById(gId));
        return genres.Any(genre => genre == null)
            ? (TrackCreationCode.InvalidGenres, null)
            : (TrackCreationCode.Successful, new Track(data.Name, album, _idGenerator.GetId(data), genres.ToArray()!));
    }
}