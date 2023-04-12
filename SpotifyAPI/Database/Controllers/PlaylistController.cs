using Database.Services;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class PlaylistController:Controller
{
    private readonly IDbPlaylistAccessor _playlistAccessor;
    private readonly IPlaylistFactory _playlistFactory;
    private readonly IDbTrackAccessor _trackAccessor;
    private readonly IDtoCreator _dtoCreator;

    public PlaylistController(IDbPlaylistAccessor playlistAccessor, IDbTrackAccessor trackAccessor, IPlaylistFactory playlistFactory, IDtoCreator dtoCreator)
    {
        _playlistAccessor = playlistAccessor;
        _trackAccessor = trackAccessor;
        _playlistFactory = playlistFactory;
        _dtoCreator = dtoCreator;
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> Create([FromBody] PlaylistCreationData data)
    {
        var playlist = await _playlistFactory.Create(data);
        if (playlist == null) return new JsonResult(new PlaylistCreationResult(PlaylistCreationCode.InvalidUser, null));
        await _playlistAccessor.Add(playlist);
        return Ok(new PlaylistCreationResult(PlaylistCreationCode.Successful, null));
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