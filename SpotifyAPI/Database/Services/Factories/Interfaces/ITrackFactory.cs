using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface ITrackFactory
{
    public Task<(TrackCreationCode, Track?)> Create(TrackCreationData data);
}