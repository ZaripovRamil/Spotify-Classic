using Database.Services.Accessors;
using Database.Services.Factories;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;

namespace Database.Controllers;
[ApiController]
[Route("[controller]")]
public class AlbumController
{
    private readonly IDbPlaylistAccessor _playlistAccessor;
    private readonly IPlaylistFactory _playlistFactory;

    public AlbumController(IDbPlaylistAccessor playlistAccessor, IPlaylistFactory playlistFactory)
    {
        _playlistAccessor = playlistAccessor;
        _playlistFactory = playlistFactory;
    }

    [HttpPost]
    [Route("Add")]
    public async Task Add([FromBody] PlaylistCreationData pData)
    {
        var playlist = await _playlistFactory.Create(pData);
        if (playlist != null)
            await _playlistAccessor.Add(playlist);
    }
}