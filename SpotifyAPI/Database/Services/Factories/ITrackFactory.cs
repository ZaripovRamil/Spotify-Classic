using Models;
using Models.DTO;

namespace Database.Services.Factories;

public interface ITrackFactory
{
    public Task<Track?> Create(TrackCreationData tData);
}