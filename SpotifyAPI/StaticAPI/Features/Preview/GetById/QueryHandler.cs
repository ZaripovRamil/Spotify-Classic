using Utils.CQRS;
using StaticAPI.Services.Interfaces;
using static StaticAPI.Constants.S3Storage;

namespace StaticAPI.Features.Preview.GetById;

public class QueryHandler : IQueryHandler<Query,Stream>
{
    private readonly IStorage _storage;

    public QueryHandler(IStorage fp)
    {
        _storage = fp;
    }

    public async Task<Result<Stream>> Handle(Query request, CancellationToken cancellationToken)
    {
        Stream? preview;
        try
        {
            preview = await _storage.GetFileAsStreamAsync(PreviewsBucketName, $"{request.Id}.jpg", cancellationToken);
        }
        catch (Exception)
        {
            return new Result<Stream>("Preview not found");
        }
        return preview is null ?
            new Result<Stream>("Preview not found") :
            new Result<Stream>(preview);
    }
}