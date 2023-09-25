using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.EntityValidators.Interfaces;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;
using Models.Entities;

namespace DatabaseServices.Services.EntityValidators.Implementations;

public class TrackValidator:EntityValidator,ITrackValidator
{
    private readonly IDbGenreAccessor _genreAccessor;
    private readonly IDbAlbumAccessor _albumAccessor;

    public TrackValidator(IDbGenreAccessor genreAccessor, IDbAlbumAccessor albumAccessor)
    {
        _genreAccessor = genreAccessor;
        _albumAccessor = albumAccessor;
    }

    public async Task<TrackValidationResult> Validate(TrackCreationData data)
    {
        var state = (TrackValidationCode) EntityValidator.Validate(data).ValidationCode;
        var album = await _albumAccessor.GetById(data.AlbumId);
        if (album == null)
            state = TrackValidationCode.InvalidAlbum;
        var genres = new List<Genre?>();
        foreach (var id in data.GenreIds)
            genres.Add(await _genreAccessor.GetById(id));
        if (genres.Contains(null))
            state = TrackValidationCode.InvalidGenres;
        return new TrackValidationResult(state, album!, genres.ToArray()!);
    }
}