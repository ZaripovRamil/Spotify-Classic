using GraphQL.Contracts.AuthAPI.Auth;
using Microsoft.AspNetCore.Http;
using Models.DTO.Albums;

namespace GraphQL.Contracts.PlayerAPI;

[ExtendObjectType("Query")]
public class GetAlbumsQuery : GraphQLRequest
{
    protected GetAlbumsQuery(IHttpContextAccessor contextAccessor) : base("http://localhost:7022", contextAccessor)
    {
    }

    public async Task<AlbumsResult?> GetAlbums()
    {
        return await Proxy.GetAsync<AlbumsResult>(TargetHostname + "/albums/get", null, Token);
    }
}