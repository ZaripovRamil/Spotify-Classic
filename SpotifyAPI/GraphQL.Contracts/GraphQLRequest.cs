using GraphQL.Proxy;
using Microsoft.AspNetCore.Http;

namespace GraphQL.Contracts;

public class GraphQLRequest
{
    protected string TargetHostname { get; }
    protected HttpProxy Proxy { get; }
    protected string? Token => HttpContextAccessor.HttpContext!.Request.Headers.Authorization;
    private IHttpContextAccessor HttpContextAccessor { get; }

    protected GraphQLRequest(string targetHostname, IHttpContextAccessor httpContextAccessor)
    {
        TargetHostname = targetHostname;
        HttpContextAccessor = httpContextAccessor;
        Proxy = new HttpProxy();
    }
}