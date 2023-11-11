using DatabaseServices.EntityValidators.Interfaces;
using DatabaseServices.Repositories;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace AdminAPI.Features.Tracks;

public interface ITrackCreateHandler
{
    public Task<TrackCreationResult> CreateAsync(TrackCreationData data);
}

public class TrackCreateHandler : ITrackCreateHandler
{
    private readonly ITrackRepository _trackRepository;
    private readonly ITrackValidator _trackValidator;

    public TrackCreateHandler(ITrackValidator trackValidator, ITrackRepository trackRepository)
    {
        _trackValidator = trackValidator;
        _trackRepository = trackRepository;
    }


    public async Task<TrackCreationResult> CreateAsync(TrackCreationData data)
    {
        var validationResult = await _trackValidator.Validate(data);
        var track = validationResult.IsValid
            ? new Track(data.Name, validationResult.Album, Guid.NewGuid().ToString(), validationResult.Genres)
            : null;
        if (track != null)
            await _trackRepository.AddAsync(track);
        return new TrackCreationResult((TrackValidationCode)validationResult.ValidationCode, track);
    }
}