using GraphQL.Contracts.AuthAPI.Auth;
using Microsoft.AspNetCore.Http;
using Models.DTO.Full;

namespace GraphQL.Contracts.PlayerAPI;
[ExtendObjectType("Query")]
public class GetAlbumQuery : GraphQLRequest
{
    protected GetAlbumQuery(IHttpContextAccessor contextAccessor) : base("http://localhost:7022", contextAccessor)
    {
    }

    public async Task<AlbumFull?> GetAlbum(string id)
    {
        return await Proxy.GetAsync<AlbumFull>(TargetHostname + $"/albums/get/{id}", null, Token);
    }
}