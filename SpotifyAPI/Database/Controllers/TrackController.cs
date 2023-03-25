using Database.Services.Accessors;
using Database.Services.Factories;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.DTO.BackToFront;
using Models.DTO.BackToFront.Light;

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
    public async Task Add([FromBody] TrackCreationData pData)
    {
        var playlist = await _trackFactory.Create(pData);
        if (playlist != null)
            await _trackAccessor.Add(playlist);
    }

    [HttpGet]
    [Route("Get")]
    public async Task<IActionResult> GetAll()
    {
        return new JsonResult(_trackAccessor.GetAll().Select(track => new TrackLight(track)));
    } 
}