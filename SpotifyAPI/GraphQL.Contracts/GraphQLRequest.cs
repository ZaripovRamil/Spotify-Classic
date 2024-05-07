using GraphQL.Proxy;
using Microsoft.AspNetCore.Http;

namespace GraphQL.Contracts;

public class GraphQLRequest
{
    protected string TargetHostname { get; }
    protected HttpProxy Proxy { get; }
    protected string? Token { get; }

    protected GraphQLRequest(string targetHostname, IHttpContextAccessor contextAccessor)
    {
        TargetHostname = targetHostname;
        Token = contextAccessor.HttpContext!.Request.Headers.Authorization;
        Proxy = new HttpProxy();
    }
}