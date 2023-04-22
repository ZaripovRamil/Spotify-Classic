using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.DeleteHandlers.Interfaces;
using Models.DTO.BackToFront.EntityCreationResult;

namespace DatabaseServices.Services.DeleteHandlers.Implementations;

public class TrackDeleteHandler : ITrackDeleteHandler
{
    private readonly IDbTrackAccessor _trackAccessor;

    public TrackDeleteHandler(IDbTrackAccessor trackAccessor)
    {
        _trackAccessor = trackAccessor;
    }

    public async Task<TrackCreationResult> HandleDeleteById(string id)
    {
        var track = await _trackAccessor.Get(id);
        var result = new TrackCreationResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (track is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested track doesn't exist";

            return result;
        }

        await _trackAccessor.Delete(track);
        
        return result;
    }
}