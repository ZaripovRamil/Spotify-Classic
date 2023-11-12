using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using AdminAPI.Dto;
using AdminAPI.Features.Albums.Get.ById;
using Utils.CQRS;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class AlbumsController : Controller
{
    private readonly IMediator _mediator;

    public AlbumsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var query = new Query(id);
        var res = await _mediator.Send(query);
        return res.IsSuccessful ? new JsonResult(res.Value!) : NotFound(res.JoinErrors());
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync([FromForm] Features.Albums.Create.RequestDto dto)
    {
        var command = new Features.Albums.Create.Command(dto.Name, dto.AuthorId, dto.AlbumType, dto.ReleaseYear,
            Guid.NewGuid(), dto.PreviewFile);
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
        var command = new Features.Albums.Delete.Command(id);
        return await SendResponse(command);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync(Features.Albums.Update.Command command)
    {
        return await SendResponse(command);
    }

    [HttpGet]
    public async Task<IActionResult> GetWithFilters([FromQuery] string? albumType, [FromQuery] int? tracksMin,
        [FromQuery] int? tracksMax, [FromQuery] int? maxCount, [FromQuery] string? sortBy, [FromQuery] string? search)
    {
        var query = new Features.Albums.Get.ByFilters.Query(albumType, tracksMin, tracksMax, maxCount, sortBy, search);
        var res = await _mediator.Send(query);
        return new JsonResult(res.Value);
    }

    [HttpGet("search")]
    public async Task<IActionResult> FindAlbumByAuthorName([FromQuery] string? query)
    {
        var q = new Features.Albums.Get.ByAuthorName.Query(query);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? new JsonResult(res.Value) : StatusCode(503, res.JoinErrors());
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