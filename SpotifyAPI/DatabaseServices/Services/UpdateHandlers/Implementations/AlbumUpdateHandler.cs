using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.UpdateHandlers.Interfaces;
using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace DatabaseServices.Services.UpdateHandlers.Implementations;

public class AlbumUpdateHandler : IAlbumUpdateHandler
{
    private readonly IDbAlbumAccessor _albumAccessor;

    public AlbumUpdateHandler(IDbAlbumAccessor albumAccessor)
    {
        _albumAccessor = albumAccessor;
    }

    public async Task<AlbumUpdateResult> HandleUpdateById(string id, AlbumUpdateData updateData)
    {
        var album = await _albumAccessor.GetById(id);
        var result = new AlbumUpdateResult { IsSuccessful = true, ResultMessage = "Successful" };
        if (album is null)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "The requested album doesn't exist";

            return result;
        }

        if (updateData.Id != album.Id)
        {
            result.IsSuccessful = false;
            result.ResultMessage = "Unable to update the id field";

            return result;
        }

        await _albumAccessor.Update(new Album(id, updateData.Name, album.Author, album.Type, album.ReleaseYear,
            album.PreviewId));
        return result;
    }
}