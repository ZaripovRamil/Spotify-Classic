using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;

namespace DatabaseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class HistoryController : Controller
{
    private readonly IDbUserAccessor _userAccessor;
    private readonly IDbTrackAccessor _trackAccessor;

    public HistoryController(IDbUserAccessor userAccessor, IDbTrackAccessor trackAccessor)
    {
        _userAccessor = userAccessor;
        _trackAccessor = trackAccessor;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Add([FromQuery] string userName, [FromQuery] string trackId)
    {
        var user = await _userAccessor.GetByUsername(userName);
        var track = await _trackAccessor.Get(trackId);
        if (user == null || track == null)
            return BadRequest("Invalid ids");
        await _userAccessor.AddTrackToHistory(user, track);
        return Ok();
    }

    [HttpGet]
    [Route("Get")]
    public async Task<IActionResult> Get([FromQuery] string userId)
    {
        var user = await _userAccessor.GetById(userId);
        if (user == null) return BadRequest("Invalid userId");
        var history = user.History;
        return new JsonResult(history.Select(t => new TrackLight(t)).ToList());
    }
}