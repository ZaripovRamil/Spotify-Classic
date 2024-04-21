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
    private readonly IAuthorRepository _authorRepository;
    private bool _savedSuccessfully;
    private static readonly object Lock = new();
    private static string _lockedItemId = string.Empty;
    private static DateTime _lockedTimestamp = DateTime.MinValue;
    private Album _album = default!;

    public DbInfoSaver(IAlbumRepository albumRepository, IAuthorRepository authorRepository)
    {
        _albumRepository = albumRepository;
        _authorRepository = authorRepository;
    }

    public Task<Result> PrepareAsync(Command item)
    {
        var successful = false;
        lock (Lock)
        {
            if (string.IsNullOrEmpty(_lockedItemId) || _lockedTimestamp.AddMinutes(1) < DateTime.Now)
            {
                _lockedItemId = item.Id;
                _lockedTimestamp = DateTime.Now;
                successful = true;
            }
        }
        if (successful) return ValidateAsync(item);

        var res = new Result();
        res.Fail();
        return Task.FromResult(res);
    }

    private async Task<Result> ValidateAsync(Command item)
    {
        var validator = new DbValidator(_authorRepository, _albumRepository);
        return await validator.ValidateAsync(item);
    }

    public Task<Result> UnPrepareAsync(Command item)
    {
        lock (Lock)
        {
            if (_lockedItemId == item.Id)
            {
                _lockedItemId = string.Empty;
                _lockedTimestamp = DateTime.MinValue;
                return Task.FromResult(new Result());
            }
        }
        
        var res = new Result();
        res.Fail();
        return Task.FromResult(res);
    }

    public async Task<Result<string>> SaveAsync(Command item)
    {
        await UnPrepareAsync(item);
        _album = new Album(item.Id, item.Name, item.AuthorId, item.AlbumType, item.ReleaseYear,
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