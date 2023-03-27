using Database.Services.Accessors;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.DTO.BackToFront;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Full;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class TrackController
{
    private readonly ITrackFactory _trackFactory;
    private readonly IDbTrackAccessor _trackAccessor;

    public TrackController(ITrackFactory trackFactory, IDbTrackAccessor trackAccessor)
    {
        _trackFactory = trackFactory;
        _trackAccessor = trackAccessor;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Add([FromBody] TrackCreationData tData)
    {
        var track = await _trackFactory.Create(tData);
        if (track == null) return new JsonResult(TrackCreationCode.InvalidAlbum);
            await _trackAccessor.Add(track);
        return new JsonResult(TrackCreationCode.InvalidAlbum);
    }

    [HttpGet]
    [Route("Get")]
    public async Task<IActionResult> GetAll()
    {
        return new JsonResult(_trackAccessor
            .GetAll()
            .Select(track => new TrackLight(track)));
    }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var track = await _trackAccessor.Get(id);
        return new JsonResult(track == null ? null : new TrackFull(track));
    }
}