using DatabaseServices.EntityValidators.Interfaces;
using DatabaseServices.Repositories;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;
using Models.Entities;

namespace DatabaseServices.EntityValidators.Implementations;

public class TrackValidator : EntityValidator, ITrackValidator
{
    private readonly IGenreRepository _genreRepository;
    private readonly IAlbumRepository _albumRepository;

    public TrackValidator(IGenreRepository genreRepository, IAlbumRepository albumRepository)
    {
        _genreRepository = genreRepository;
        _albumRepository = albumRepository;
    }

    public async Task<TrackValidationResult> Validate(TrackCreationData data)
    {
        var state = (TrackValidationCode)EntityValidator.Validate(data).ValidationCode;
        var album = await _albumRepository.GetByIdAsync(data.AlbumId);
        if (album == null)
            state = TrackValidationCode.InvalidAlbum;
        var genres = new List<Genre?>();
        foreach (var id in data.GenreIds)
            genres.Add(await _genreRepository.GetByIdAsync(id));
        if (genres.Contains(null))
            state = TrackValidationCode.InvalidGenres;
        return new TrackValidationResult(state, album!, genres.ToArray()!);
    }
}