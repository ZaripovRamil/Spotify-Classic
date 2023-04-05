using Database.Services;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class TrackController
{
    private readonly ITrackFactory _trackFactory;
    private readonly IDbTrackAccessor _trackAccessor;
    private readonly IDtoCreator _dtoCreator;

    public TrackController(ITrackFactory trackFactory, IDbTrackAccessor trackAccessor, IDtoCreator dtoCreator)
    {
        _trackFactory = trackFactory;
        _trackAccessor = trackAccessor;
        _dtoCreator = dtoCreator;
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
    public Task<IActionResult> GetAll()
    {
        var tracks = _trackAccessor
            .GetAll()
            .Select(track => new TrackLight(track));
        return Task.FromResult<IActionResult>(new JsonResult(tracks));
    }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _trackAccessor.GetById(id)));
    }
}