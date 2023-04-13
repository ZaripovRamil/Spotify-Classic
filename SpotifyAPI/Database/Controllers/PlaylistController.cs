using Database.Services;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class PlaylistController:Controller
{
    private readonly IDbUserAccessor _userAccessor;
    private readonly IDbPlaylistAccessor _playlistAccessor;
    private readonly IPlaylistFactory _playlistFactory;
    private readonly IDbTrackAccessor _trackAccessor;
    private readonly IDtoCreator _dtoCreator;

    public PlaylistController(IDbPlaylistAccessor playlistAccessor, IDbTrackAccessor trackAccessor, IPlaylistFactory playlistFactory, IDtoCreator dtoCreator, IDbUserAccessor userAccessor)
    {
        _playlistAccessor = playlistAccessor;
        _trackAccessor = trackAccessor;
        _playlistFactory = playlistFactory;
        _dtoCreator = dtoCreator;
        _userAccessor = userAccessor;
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> ProcessPlaylistCreation([FromBody] PlaylistCreationData data)
    {
        return new JsonResult(new PlaylistCreationResult(await CreatePlaylist(data)));
    }

    private async Task<(PlaylistCreationCode, Playlist?)>CreatePlaylist(PlaylistCreationData data)
    {
        if (await _userAccessor.GetById(data.OwnerId) == null) return (PlaylistCreationCode.InvalidUser, null);
        var playlist = await _playlistFactory.Create(data);
        if (playlist == null) return (PlaylistCreationCode.UnknownError, null);
        await _playlistAccessor.Add(playlist);
        return (PlaylistCreationCode.Successful, playlist);
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> AddTrack([FromBody] PlaylistTrackAdditionData data)
    {
        var playlist =await _playlistAccessor.Get(data.playlistId);
        var track =await _trackAccessor.Get(data.trackId);
        if (playlist == null || track == null)
            return BadRequest();
        _playlistAccessor.AddTrack(playlist, track);
        return Ok();
    }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _playlistAccessor.Get(id)));
    }
}