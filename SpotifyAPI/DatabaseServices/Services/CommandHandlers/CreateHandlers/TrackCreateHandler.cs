using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace DatabaseServices.Services.CommandHandlers.CreateHandlers;

public interface ITrackCreateHandler
{
    public Task<TrackCreationResult> Create(TrackCreationData data);
}

public class TrackCreateHandler : ITrackCreateHandler
{
    private readonly ITrackRepository _trackRepository;
    private readonly IFileIdGenerator _idGenerator;
    private readonly ITrackValidator _trackValidator;

    public TrackCreateHandler(IFileIdGenerator idGenerator,
        ITrackValidator trackValidator, ITrackRepository trackRepository)
    {
        _idGenerator = idGenerator;
        _trackValidator = trackValidator;
        _trackRepository = trackRepository;
    }


    public async Task<TrackCreationResult> Create(TrackCreationData data)
    {
        var validationResult = await _trackValidator.Validate(data);
        var track = validationResult.IsValid
            ? new Track(data.Name, validationResult.Album, _idGenerator.GetId(data), validationResult.Genres)
            : null;
        if (track != null)
            await _trackRepository.AddAsync(track);
        return new TrackCreationResult((TrackValidationCode)validationResult.ValidationCode, track);
    }
}