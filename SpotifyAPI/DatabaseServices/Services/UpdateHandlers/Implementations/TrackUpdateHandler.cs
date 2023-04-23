using DatabaseServices.Services.Accessors.Implementations;
using DatabaseServices.Services.UpdateHandlers.Interfaces;
using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace DatabaseServices.Services.UpdateHandlers.Implementations;

public class TrackUpdateHandler : ITrackUpdateHandler
{
    private readonly DbTrackAccessor _trackAccessor;

    public TrackUpdateHandler(DbTrackAccessor trackAccessor)
    {
        _trackAccessor = trackAccessor;
    }

    public async Task<TrackUpdateResult> HandleUpdateById(string id, TrackUpdateData updateData)
    {
        var track = await _trackAccessor.Get(id);
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

        await _trackAccessor.Update(new Track(id, updateData.Name, track.Album, track.FileId));
        return result;
    }
}