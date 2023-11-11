using DatabaseServices.Repositories;
using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.CommandHandlers.DeleteHandlers;

public interface IAlbumDeleteHandler
{
    Task<AlbumDeletionResult> DeleteAsync(string id);
}

public class AlbumDeleteHandler : IAlbumDeleteHandler
{
    private readonly IAlbumRepository _albumRepository;

    public AlbumDeleteHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<AlbumDeletionResult> DeleteAsync(string id)
    {
        var album = await _albumRepository.GetByIdAsync(id);
        var result = new AlbumDeletionResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (album is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested album doesn't exist";

            return result;
        }

        if (album.Tracks.Count > 0)
        {
            result.IsSuccessful = false;
            result.ResultMessage =
                "The requested album contains at least one track. It should be empty for safe delete.";

            return result;
        }

        await _albumRepository.DeleteAsync(album);

        return result;
    }
}