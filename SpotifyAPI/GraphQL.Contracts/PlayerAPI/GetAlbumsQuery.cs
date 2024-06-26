﻿using Microsoft.AspNetCore.Http;
using Models.DTO.Albums;
using Models.DTO.Light;

namespace GraphQL.Contracts.PlayerAPI;

[ExtendObjectType("Query")]
public class GetAlbumsQuery: GraphQLRequest
{
    public GetAlbumsQuery(IHttpContextAccessor httpContextAccessor) : base("https://localhost:7022", httpContextAccessor)
    {
    }
    
    public async Task<AlbumsResult?> GetAlbums()
    {
        var albums = await Proxy.GetAsync<List<AlbumLight>>(TargetHostname + "/albums/get", null, Token);
        return new AlbumsResult(albums);
    }
}