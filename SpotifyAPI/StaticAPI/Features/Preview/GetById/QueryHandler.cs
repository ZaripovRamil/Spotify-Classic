using Utils.CQRS;
using StaticAPI.Services;

namespace StaticAPI.Features.Preview.GetById;

public class QueryHandler : IQueryHandler<Query,Stream>
{
    private readonly IFileProvider _fileProvider;

    public QueryHandler(IFileProvider fp, IHlsConverter hlsConverter)
    {
        _fileProvider = fp;
    }

    public Task<Result<Stream>> Handle(Query request, CancellationToken cancellationToken)
    {
        var preview = _fileProvider.GetFileAsStream("Previews", $"{request.Id}.jpg");
        return preview is null ?
            Task.FromResult(new Result<Stream>("Preview not found") ):
            Task.FromResult(new Result<Stream>(preview));
    }
}