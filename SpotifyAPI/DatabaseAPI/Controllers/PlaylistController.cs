using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.DeleteHandlers.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using DatabaseServices.Services.UpdateHandlers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;
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
    private readonly IPlaylistDeleteHandler _playlistDeleteHandler;
    private readonly IPlaylistUpdateHandler _playlistUpdateHandler;

    public PlaylistController(IDbPlaylistAccessor playlistAccessor, IDbTrackAccessor trackAccessor,
        IPlaylistFactory playlistFactory, IDtoCreator dtoCreator, IPlaylistUpdateHandler playlistUpdateHandler,
        IPlaylistDeleteHandler playlistDeleteHandler)
    {
        _playlistAccessor = playlistAccessor;
        _trackAccessor = trackAccessor;
        _playlistFactory = playlistFactory;
        _dtoCreator = dtoCreator;
        _playlistUpdateHandler = playlistUpdateHandler;
        _playlistDeleteHandler = playlistDeleteHandler;
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
    public async Task<IActionResult> AddTrack([FromBody] PlaylistTrackOperationDataWithUser data)
    {
        var playlist = await _playlistAccessor.Get(data.PlaylistId);
        var track = await _trackAccessor.Get(data.TrackId);
        if (playlist == null || track == null)
            return BadRequest();
        if (playlist.Owner.UserName != data.UserName)
            return Forbid();
        await _playlistAccessor.AddTrack(playlist, track);
        return Ok();
    }

    [HttpPost]
    [Route("[action]")]
    public async Task<IActionResult> DeleteTrack([FromBody] PlaylistTrackOperationDataWithUser data)
    {
        var playlist = await _playlistAccessor.Get(data.PlaylistId);
        var track = await _trackAccessor.Get(data.TrackId);
        if (playlist == null || track == null)
            return BadRequest();
        if (playlist.Owner.UserName != data.UserName)
            return Forbid();
        await _playlistAccessor.DeleteTrack(playlist, track);
        return Ok();
    }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _playlistAccessor.Get(id)));
    }

    [HttpGet]
    [Route("Get")]
    public Task<IActionResult> GetAll()
    {
        return Task.FromResult<IActionResult>(new JsonResult(_playlistAccessor.GetAll()
            .Select(playlist => _dtoCreator.CreateFull(playlist))));
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> DeleteById(string id)
    {
        return new JsonResult(await _playlistDeleteHandler.HandleDeleteById(id));
    }

    [HttpPut]
    [Route("update/{id}")]
    public async Task<IActionResult> UpdateById(string id, PlaylistUpdateData playlistUpdateData)
    {
        return new JsonResult(await _playlistUpdateHandler.HandleUpdateById(id, playlistUpdateData));
    }
}