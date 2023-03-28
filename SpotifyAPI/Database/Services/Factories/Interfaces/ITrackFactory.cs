using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Services.Factories.Interfaces;

public interface ITrackFactory
{
    public Task<Track?> Create(TrackCreationData tData);
}