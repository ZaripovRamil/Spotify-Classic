using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace DatabaseServices.Services.CommandHandlers.UpdateHandlers;

public interface ITrackUpdateHandler
{
    Task<TrackUpdateResult> UpdateAsync(string id, TrackUpdateData updateData);
}

public class TrackUpdateHandler : ITrackUpdateHandler
{
    private readonly ITrackRepository _trackRepository;

    public TrackUpdateHandler(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
    }

    public async Task<TrackUpdateResult> UpdateAsync(string id, TrackUpdateData updateData)
    {
        var track = await _trackRepository.GetByIdAsync(id);
        var result = new TrackUpdateResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (track is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested track doesn't exist";

            return result;
        }

        if (updateData.Id != track.Id)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "Unable to update the id field";

            return result;
        }

        await _trackRepository.UpdateAsync(new Track(id, updateData.Name, track.Album, track.FileId));
        return result;
    }
}