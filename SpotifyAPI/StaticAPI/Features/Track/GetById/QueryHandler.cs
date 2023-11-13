using StaticAPI.Services;
using Utils.CQRS;

namespace StaticAPI.Features.Track.GetById;

public class QueryHandler : IQueryHandler<Query,Stream>
{
    private readonly IFileProvider _fileProvider;

    public QueryHandler(IFileProvider fp)
    {
        _fileProvider = fp;
    }
    public Task<Result<Stream>> Handle(Query request, CancellationToken cancellationToken)
    {
        var id = request.Id;
        var idSplit = id.Split('.');
        var fileName = Path.Combine(idSplit[0], idSplit.Length > 1 ? id : $"{id}.index.m3u8");
        var track = _fileProvider.GetFileAsStream("Tracks", fileName);
        return track is null ? 
            Task.FromResult(new Result<Stream>("Track not found")) :
            Task.FromResult(new Result<Stream>(track));
    }
}