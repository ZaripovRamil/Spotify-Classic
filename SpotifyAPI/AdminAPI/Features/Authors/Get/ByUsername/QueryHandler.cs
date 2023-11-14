using Models.Configuration;
using Models.DTO.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Authors.Get.ByUsername;

public class QueryHandler : IQueryHandler<Query, IEnumerable<AuthorFull>>
{
    private readonly IHttpClientFactory _httpClientFactory;

    public QueryHandler(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<Result<IEnumerable<AuthorFull>>> Handle(Query request, CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(nameof(Hosts.SearchApi));
        IEnumerable<AuthorFull>? authors;
        try
        {
            authors = await client.GetFromJsonAsync<IEnumerable<AuthorFull>>(
                $"authors/by/user?query={request.Username}", cancellationToken: cancellationToken);
        }
        catch (Exception)
        {
            return new Result<IEnumerable<AuthorFull>>("Network error. Please try again later");
        }
        
        return new Result<IEnumerable<AuthorFull>>(authors ?? Array.Empty<AuthorFull>());
    }
}