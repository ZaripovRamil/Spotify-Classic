using Database.Services.Accessors;
using Database.Services.Factories;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.DTO.BackToFront;

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
        // TODO: may be extract this logic to separate data mapper?
        return new JsonResult(_trackAccessor.GetAll().Select(track => new TrackLight
        {
            Id = track.Id,
            Name = track.Name,
            PreviewId = track.Id, 
            Author = new AuthorLight
            {
                Id = track.Album.Owner.Id,
                Name = track.Album.Owner.Name 
            },
            Album = new AlbumLight
            {
                Id = track.Album.Id,
                Name = track.Album.Name
            }
        }));
    } 
}