using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface ITrackFactory
{
    public Task<(TrackValidationCode, Track?)> Create(TrackCreationData data);
}