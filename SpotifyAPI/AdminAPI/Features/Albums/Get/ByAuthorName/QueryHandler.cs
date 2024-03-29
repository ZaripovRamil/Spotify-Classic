using Models.Configuration;
using Models.DTO.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Get.ByAuthorName;

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
            albums = await client.GetFromJsonAsync<IEnumerable<AlbumFull>>(
                $"albums/by/author?query={request.SearchQuery}", cancellationToken: cancellationToken);
        }
        catch (Exception)
        {
            return new Result<IEnumerable<AlbumFull>>("Network error. Please try again later");
        }
        
        return new Result<IEnumerable<AlbumFull>>(albums ?? Array.Empty<AlbumFull>());
    }
}