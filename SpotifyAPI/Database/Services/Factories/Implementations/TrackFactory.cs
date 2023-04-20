using Database.Services.EntityValidators.Interfaces;
using Database.Services.Factories.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Database.Services.Factories.Implementations;

public class TrackFactory : ITrackFactory
{
    private readonly IFileIdGenerator _idGenerator;
    private readonly ITrackValidator _trackValidator;

    public TrackFactory(IFileIdGenerator idGenerator,
        ITrackValidator trackValidator)
    {
        _idGenerator = idGenerator;
        _trackValidator = trackValidator;
    }


    public async Task<(TrackValidationCode, Track?)> Create(TrackCreationData data)
    {
        var validationResult = _trackValidator.Validate(data);
        return (validationResult.ValidationCode,
            validationResult.IsValid
                ? new Track(data.Name, validationResult.Album, _idGenerator.GetId(data), validationResult.Genres)
                : null);
    }
}