using Models.Configuration;
using Models.DTO.BackToFront.Full;
using Models.Entities;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.GetByAuthorName;

public class QueryHandler : IQueryHandler<Query, IEnumerable<AlbumFull>>
{
    private readonly IHttpClientFactory _httpClientFactory;

    public QueryHandler(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<Result<IEnumerable<AlbumFull>>> Handle(Query request, CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(nameof(Hosts.SearchApi));
        IEnumerable<AlbumFull>? albums;
        try
        {
            albums = (await client.GetFromJsonAsync<IEnumerable<Album>>(
                    $"albums/by/author?query={request.SearchQuery}", cancellationToken: cancellationToken))?
                .Select(a => new AlbumFull(a));
        }
        catch (Exception e)
        {
            return new Result<IEnumerable<AlbumFull>>("Network error. Please try again later");
        }
        
        return new Result<IEnumerable<AlbumFull>>(albums ?? Array.Empty<AlbumFull>());
    }
}