using Microsoft.AspNetCore.Http;
using Models.DTO.Search;

namespace GraphQL.Contracts.SearchAPI;

[ExtendObjectType("Query")]
public class SearchQuery : GraphQLRequest
{
    public SearchQuery(IHttpContextAccessor contextAccessor) : base("http://localhost:5282", contextAccessor)
    {
    }

    public async Task<SearchResult?> Search(string query)
    {
        var queryParams = new Dictionary<string, string> { { "query", query } };
        return await Proxy.GetAsync<SearchResult>(TargetHostname + "/search", queryParams, Token);
    }
}