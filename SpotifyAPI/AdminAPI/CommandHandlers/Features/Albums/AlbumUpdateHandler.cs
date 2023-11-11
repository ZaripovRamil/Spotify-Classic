using DatabaseServices.Repositories;
using Models.DTO.BackToFront.EntityUpdateResult;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace DatabaseServices.CommandHandlers.UpdateHandlers;

public interface IAlbumUpdateHandler
{
    Task<AlbumUpdateResult> UpdateAsync(string id, AlbumUpdateData updateData);
}

public class AlbumUpdateHandler : IAlbumUpdateHandler
{
    private readonly IAlbumRepository _albumRepository;

    public AlbumUpdateHandler(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<AlbumUpdateResult> UpdateAsync(string id, AlbumUpdateData updateData)
    {
        var album = await _albumRepository.GetByIdAsync(id);
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

        await _albumRepository.UpdateAsync(new Album(id, updateData.Name, album.Author, album.Type, album.ReleaseYear,
            album.PreviewId));
        return result;
    }
}