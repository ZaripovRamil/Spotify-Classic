using Models;
using Models.DTO;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Services.Factories.Interfaces;

public interface ITrackFactory
{
    public Task<Track?> Create(TrackCreationData tData);
}