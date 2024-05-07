using Microsoft.AspNetCore.Http;
using Models.DTO.Auth;

namespace GraphQL.Contracts.AuthAPI.User;

[ExtendObjectType("Query")]
public class GetHistoryQuery : GraphQLRequest
{
    public GetHistoryQuery(IHttpContextAccessor contextAccessor) : base("http://localhost:5209", contextAccessor)
    {
    }

    public async Task<HistoryResult?> GetHistory()
    {
        return await Proxy.GetAsync<HistoryResult>(TargetHostname + "/user/gethistory", null, Token);
    }
}