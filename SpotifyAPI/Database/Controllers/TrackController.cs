using Database.Services;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class TrackController
{
    private readonly ITrackFactory _trackFactory;
    private readonly IDbTrackAccessor _trackAccessor;
    private readonly IDtoCreator _dtoCreator;
    private readonly IDbAlbumAccessor _albumAccessor;

    public TrackController(ITrackFactory trackFactory, IDbTrackAccessor trackAccessor, IDtoCreator dtoCreator, IDbAlbumAccessor albumAccessor)
    {
        _trackFactory = trackFactory;
        _trackAccessor = trackAccessor;
        _dtoCreator = dtoCreator;
        _albumAccessor = albumAccessor;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Add([FromBody] TrackCreationData data)
    {
        return new JsonResult(new TrackCreationResult(await CreateTrack(data)));
    }

    public async Task<(TrackCreationCode, Track?)> CreateTrack(TrackCreationData data)
    {
        if (await _albumAccessor.GetById(data.AlbumId) == null) return (TrackCreationCode.InvalidAlbum, null);
        var track =await _trackFactory.Create(data);
        if (track == null) return (TrackCreationCode.UnknownError, null);
        await _trackAccessor.Add(track);
        return (TrackCreationCode.Successful, track);
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
        return new JsonResult(_dtoCreator.CreateFull(await _trackAccessor.Get(id)));
    }
}