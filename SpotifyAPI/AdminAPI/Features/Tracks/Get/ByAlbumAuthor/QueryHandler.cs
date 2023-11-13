using Models.Configuration;
using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Get.ByAlbumAuthor;

public class QueryHandler : IQueryHandler<Query, IEnumerable<TrackFull>>
{
    private readonly IHttpClientFactory _httpClientFactory;

    public QueryHandler(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<Result<IEnumerable<TrackFull>>> Handle(Query request, CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(nameof(Hosts.SearchApi));
        IEnumerable<TrackFull>? tracks;
        try
        {
            tracks = await client.GetFromJsonAsync<IEnumerable<TrackFull>>(
                $"tracks/by/albumAuthor?query={request.SearchQuery}", cancellationToken: cancellationToken);
        }
        catch (Exception)
        {
            return new Result<IEnumerable<TrackFull>>("Network error. Please try again later");
        }
        
        return new Result<IEnumerable<TrackFull>>(tracks ?? Array.Empty<TrackFull>());
    }
}