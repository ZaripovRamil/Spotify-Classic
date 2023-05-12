using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;

namespace DatabaseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PlaylistController : Controller
{
    private readonly IDbPlaylistAccessor _playlistAccessor;
    private readonly IPlaylistFactory _playlistFactory;
    private readonly IDbTrackAccessor _trackAccessor;
    private readonly IDtoCreator _dtoCreator;

    public PlaylistController(IDbPlaylistAccessor playlistAccessor, IDbTrackAccessor trackAccessor,
        IPlaylistFactory playlistFactory, IDtoCreator dtoCreator)
    {
        _playlistAccessor = playlistAccessor;
        _trackAccessor = trackAccessor;
        _playlistFactory = playlistFactory;
        _dtoCreator = dtoCreator;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> ProcessPlaylistCreation([FromBody] PlaylistCreationData data)
    {
        var (state, playlist) = await _playlistFactory.Create(data);
        if (state == PlaylistValidationCode.Successful) await _playlistAccessor.Add(playlist!);
        return new JsonResult(new PlaylistCreationResult(state, playlist));
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> AddTrack([FromBody] PlaylistTrackAdditionData data)
    {
        var playlist = await _playlistAccessor.Get(data.playlistId);
        var track = await _trackAccessor.Get(data.trackId);
        if (playlist == null || track == null)
            return BadRequest();
        await _playlistAccessor.AddTrack(playlist, track);
        return Ok();
    }
    
    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> DeleteTrack([FromBody] PlaylistTrackAdditionData data)
    {
        var playlist = await _playlistAccessor.Get(data.playlistId);
        var track = await _trackAccessor.Get(data.trackId);
        if (playlist == null || track == null)
            return BadRequest();
        await _playlistAccessor.AddTrack(playlist, track);
        return Ok();
    }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _playlistAccessor.Get(id)));
    }
}