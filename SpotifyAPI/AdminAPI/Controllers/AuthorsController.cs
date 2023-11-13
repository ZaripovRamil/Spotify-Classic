using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Utils.CQRS;
using AdminAPI.Dto;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("authors")]
public class AuthorsController : Controller
{
    private readonly IMediator _mediator;

    public AuthorsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var query = new Features.Authors.Get.All.Query();
        var res = await _mediator.Send(query);
        return new JsonResult(res.Value);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var query = new Features.Authors.Get.ById.Query(id);
        var res = await _mediator.Send(query);
        return res.IsSuccessful ? new JsonResult(res.Value!) : NotFound(res.JoinErrors());
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync([FromBody] Features.Authors.Create.Command command)
    {
        var res = await _mediator.Send(command);
        return res.IsSuccessful switch
        {
            false => BadRequest(new Features.Authors.Create.ResultDto(false, res.JoinErrors(), null)),
            true when res.Value!.IsSuccessful => new JsonResult(res.Value),
            _ => BadRequest(res.Value)
        };
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(string id)
    {
        var command = new Features.Authors.Delete.Command(id);
        return await SendResponse(command);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync(Features.Authors.Update.Command command)
    {
        return await SendResponse(command);
    }

    [HttpGet("search")]
    public async Task<IActionResult> FindAuthorByUserName([FromQuery] string? query)
    {
        var q = new Features.Authors.Get.ByUsername.Query(query);
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