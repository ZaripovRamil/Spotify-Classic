using AdminAPI.Services;
using DatabaseServices.Repositories;
using Models.Entities;
using Utils.CQRS;
using Utils.CQRS.ServiceDefinition;

namespace AdminAPI.Features.Tracks.Create.TracksSavers;

[ServiceDefinition(ServiceLifetime.Scoped)]
public class DbInfoSaver : ISaver<Command, string>
{
    private readonly ITrackRepository _trackRepository;
    private readonly IGenreRepository _genreRepository;
    private bool _savedSuccessfully;
    private Track _track = default!;

    public DbInfoSaver(ITrackRepository trackRepository, IGenreRepository genreRepository)
    {
        _trackRepository = trackRepository;
        _genreRepository = genreRepository;
    }

    public async Task<Result> PrepareAsync(Command item)
    {
        throw new NotImplementedException();
    }

    public async Task<Result> UnPrepareAsync(Command item)
    {
        throw new NotImplementedException();
    }

    public async Task<Result<string>> SaveAsync(Command item)
    {
        var genresTasks = item.GenreIds.Select(async i => (await _genreRepository.GetByIdAsync(i))!).ToArray();
        await Task.WhenAll(genresTasks);
        var genres = genresTasks.Select(t => t.Result).ToArray();
        _track = new Track(item.Name, item.AlbumId, item.FileId, genres);
        try
        {
            await _trackRepository.AddAsync(_track);
        }
        catch (Exception e)
        {
            _savedSuccessfully = false;
            return new Result<string>(errors: e.Message);
        }

        _savedSuccessfully = true;
        return new Result<string>(value: _track.Id);
    }

    public async Task<Result> UnSaveAsync(Command item)
    {
        if (!_savedSuccessfully) return new Result();
        try
        {
            await _trackRepository.DeleteAsync(_track);
        }
        catch (Exception e)
        {
            return new Result(e.Message);
        }
        
        return new Result();
    }
}