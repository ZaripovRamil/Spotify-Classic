using Utils.CQRS;
using StaticAPI.Services;
using static StaticAPI.Constants.S3Storage;

namespace StaticAPI.Features.Preview.GetById;

public class QueryHandler : IQueryHandler<Query,Stream>
{
    private readonly IFileProvider _fileProvider;

    public QueryHandler(IFileProvider fp)
    {
        _fileProvider = fp;
    }

    public async Task<Result<Stream>> Handle(Query request, CancellationToken cancellationToken)
    {
        var preview =
            await _fileProvider.GetFileAsStreamAsync(PreviewsBucketName, $"{request.Id}.jpg", cancellationToken);
        return preview is null ?
            new Result<Stream>("Preview not found") :
            new Result<Stream>(preview);
    }
}