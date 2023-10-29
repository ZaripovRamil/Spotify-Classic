using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.CommandHandlers.DeleteHandlers;

public interface ITrackDeleteHandler
{
    Task<TrackDeletionResult> Delete(string id);
}

public class TrackDeleteHandler : ITrackDeleteHandler
{
    private readonly ITrackRepository _trackRepository;

    public TrackDeleteHandler(ITrackRepository trackRepository)
    {
        _trackRepository = trackRepository;
    }

    public async Task<TrackDeletionResult> Delete(string id)
    {
        var track = await _trackRepository.GetByIdAsync(id);
        var result = new TrackDeletionResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (track is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested track doesn't exist";

            return result;
        }

        await _trackRepository.DeleteAsync(track);

        return result;
    }
}