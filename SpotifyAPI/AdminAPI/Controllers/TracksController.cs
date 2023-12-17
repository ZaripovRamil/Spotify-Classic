using AdminAPI.Dto;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Utils.CQRS;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private readonly IMediator _mediator;

    public TracksController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var query = new Features.Tracks.Get.ById.Query(id);
        var res = await _mediator.Send(query);
        return res.IsSuccessful ? new JsonResult(res.Value!) : NotFound(res.JoinErrors());
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync([FromForm] Features.Tracks.Create.RequestDto dto)
    {
        var command = new Features.Tracks.Create.Command(dto.Name, dto.AlbumId, Guid.NewGuid().ToString(), dto.GenreIds, null,
            dto.TrackFile);
        var res = await _mediator.Send(command);
        return res.IsSuccessful switch
        {
            false => BadRequest(new Features.Albums.Create.ResultDto(false, res.JoinErrors(), null)),
            true when res.Value!.IsSuccessful => new JsonResult(res.Value),
            _ => BadRequest(res.Value)
        };
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        var command = new Features.Tracks.Delete.Command(id);
        return await SendResponse(command);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync(Features.Tracks.Update.Command command)
    {
        return await SendResponse(command);
    }

    [HttpGet("search")]
    public async Task<IActionResult> FindTrackByAlbumAuthor([FromQuery] string? query)
    {
        var q = new Features.Tracks.Get.ByAlbumAuthor.Query(query);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? new JsonResult(res.Value) : StatusCode(503, res.JoinErrors());
    }

    [HttpGet]
    public async Task<IActionResult> GetWithFiltersAsync([FromQuery] int? pageSize, [FromQuery] int? pageIndex,
        [FromQuery] string? sortBy, [FromQuery] string? search)
    {
        pageSize ??= 20;
        pageIndex ??= 1;
     
        var query = new Features.Tracks.Get.ByFilters.Query(pageSize.Value, pageIndex.Value, sortBy, search);
        var res = await _mediator.Send(query);
        return new JsonResult(res.Value);
    }
    
    private async Task<IActionResult> SendResponse<T>(T request) where T : ICommand<ResultDto>
    {
        var res = await _mediator.Send(request);
        return res.IsSuccessful switch
        {
            false => BadRequest(new ResultDto(false, res.JoinErrors())),
            true when res.Value!.IsSuccessful => new JsonResult(res.Value),
            _ => BadRequest(res.Value)
        };
    }
}