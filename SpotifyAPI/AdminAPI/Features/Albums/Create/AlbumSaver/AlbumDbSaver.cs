using AdminAPI.Services;
using DatabaseServices.Repositories;
using Models.Entities;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Create.AlbumSaver;

public class AlbumDbSaver : ISaver<Command>
{
    private readonly IAlbumRepository _albumRepository;
    private bool _savedSuccessfully;
    private Album _album = default!;

    public AlbumDbSaver(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Result> SaveAsync(Command item)
    {
        _album = new Album(item.Name, item.AuthorId.ToString(), item.AlbumType, item.ReleaseYear,
            item.PreviewId.ToString());
        try
        {
            await _albumRepository.AddAsync(_album);
        }
        catch (Exception e)
        {
            _savedSuccessfully = false;
            return new Result(e.Message);
        }
        
        _savedSuccessfully = true;
        return new Result();
    }

    public async Task<Result> UnSaveAsync(Command item)
    {
        if (!_savedSuccessfully) return new Result();
        try
        {
            await _albumRepository.DeleteAsync(_album);
        }
        catch (Exception e)
        {
            return new Result(e.Message);
        }
        
        return new Result();
    }
}