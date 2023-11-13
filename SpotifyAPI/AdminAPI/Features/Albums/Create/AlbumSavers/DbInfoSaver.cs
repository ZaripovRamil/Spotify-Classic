using AdminAPI.Services;
using DatabaseServices.Repositories;
using Models.Entities;
using Utils.CQRS;
using Utils.CQRS.ServiceDefinition;

namespace AdminAPI.Features.Albums.Create.AlbumSavers;

[ServiceDefinition(ServiceLifetime.Scoped)]
public class DbInfoSaver : ISaver<Command, string>
{
    private readonly IAlbumRepository _albumRepository;
    private bool _savedSuccessfully;
    private Album _album = default!;

    public DbInfoSaver(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    public async Task<Result<string>> SaveAsync(Command item)
    {
        _album = new Album(item.Name, item.AuthorId, item.AlbumType, item.ReleaseYear,
            item.PreviewId);
        try
        {
            await _albumRepository.AddAsync(_album);
        }
        catch (Exception e)
        {
            _savedSuccessfully = false;
            return new Result<string>(errors: e.Message);
        }
        
        _savedSuccessfully = true;
        return new Result<string>(value: _album.Id);
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