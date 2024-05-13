using Microsoft.AspNetCore.Http;
using Models.DTO.Full;

namespace GraphQL.Contracts.PlayerAPI;
[ExtendObjectType("Query")]
public class GetAlbumQuery : GraphQLRequest
{
    public GetAlbumQuery(IHttpContextAccessor httpContextAccessor) : base("https://localhost:7022", httpContextAccessor)
    {
    }

    public async Task<AlbumFull?> GetAlbum(string id)
    {
        return await Proxy.GetAsync<AlbumFull>(TargetHostname + $"/albums/get/{id}", null, Token);
    }
}