using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.DeleteHandlers.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using DatabaseServices.Services.UpdateHandlers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Full;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.DTO.InterServices.EntityValidationCodes;

namespace DatabaseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TrackController
{
    private readonly ITrackFactory _trackFactory;
    private readonly IDbTrackAccessor _trackAccessor;
    private readonly IDtoCreator _dtoCreator;
    private readonly ITrackDeleteHandler _trackDeleteHandler;
    private readonly ITrackUpdateHandler _trackUpdateHandler;

    public TrackController(ITrackFactory trackFactory, IDbTrackAccessor trackAccessor, IDtoCreator dtoCreator, ITrackDeleteHandler trackDeleteHandler, ITrackUpdateHandler trackUpdateHandler)
    {
        _trackFactory = trackFactory;
        _trackAccessor = trackAccessor;
        _dtoCreator = dtoCreator;
        _trackDeleteHandler = trackDeleteHandler;
        _trackUpdateHandler = trackUpdateHandler;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> ProcessTrackCreation([FromBody] TrackCreationData data)
    {
        var (state, track) = await _trackFactory.Create(data);
        if (state == TrackValidationCode.Successful) await _trackAccessor.Add(track!);
        return new JsonResult(new TrackCreationResult(state, track));
    }

    // [HttpGet]
    // [Route("Get")]
    // public Task<IActionResult> GetAll()
    // {
    //     var tracks = _trackAccessor
    //         .GetAll()
    //         .Select(track => _dtoCreator.CreateFull(track));
    //     return Task.FromResult<IActionResult>(new JsonResult(tracks));
    // }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _trackAccessor.Get(id)));
        // var track = await _trackAccessor.Get(id);
        // return track is null ? new NotFoundResult() : new JsonResult(new TrackLight(track));
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> DeleteById(string id)
    {
        return new JsonResult(await _trackDeleteHandler.HandleDeleteById(id));
    }

    [HttpPut]
    [Route("update/{id}")]
    public async Task<IActionResult> UpdateById(string id, TrackUpdateData trackUpdateData)
    {
        return new JsonResult(await _trackUpdateHandler.HandleUpdateById(id, trackUpdateData));
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetWithFiltersAsync([FromQuery] int? pageSize, [FromQuery] int? pageIndex, [FromQuery] string? search)
    {
        return new JsonResult(_trackAccessor.GetAll().AsEnumerable().Where(t =>
                search == null || t.Name.ToLower().Contains(search.ToLower()))
            .Take(new Range((pageSize ?? 20) * (pageIndex ?? 1 - 1), (pageIndex ?? 1) * (pageSize ?? 20)))
            .Select(t => new TrackFull(t)));
    }
}