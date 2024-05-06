using Microsoft.AspNetCore.Http;
using Models.DTO.Auth;

namespace GraphQL.Contracts.AuthAPI.User;

public class GetHistoryQuery : GraphQLRequest
{
    public GetHistoryQuery(IHttpContextAccessor contextAccessor) : base("http://localhost:7249", contextAccessor)
    {
    }

    public async Task<HistoryResult?> Register(RegistrationData registrationData)
    {
        return await Proxy.GetAsync<HistoryResult>(TargetHostname + "/user/gethistory", null, Token);
    }
}