using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.DeleteHandlers.Interfaces;
using Models.DTO.BackToFront.EntityDeletionResult;

namespace DatabaseServices.Services.DeleteHandlers.Implementations;

public class AlbumDeleteHandler : IAlbumDeleteHandler
{
    private readonly IDbAlbumAccessor _albumAccessor;

    public AlbumDeleteHandler(IDbAlbumAccessor albumAccessor)
    {
        _albumAccessor = albumAccessor;
    }

    public async Task<AlbumDeletionResult> HandleDeleteById(string id)
    {
        var album = await _albumAccessor.GetById(id);
        var result = new AlbumDeletionResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (album is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested album doesn't exist";

            return result;
        }
        else if (album.Tracks.Count > 0)
        {
            result.IsSuccessful = false;
            result.ResultMessage =
                "The requested album contains at least one track. It should be empty for safe delete.";

            return result;
        }

        await _albumAccessor.Delete(album);
        
        return result;
    }
}