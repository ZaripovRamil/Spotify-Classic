using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class GenresController : Controller
{
    private readonly IMediator _mediator;

    public GenresController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync([FromForm] Features.Genres.Create.Command command)
    {
        var res = await _mediator.Send(command);
        return res.IsSuccessful switch
        {
            false => BadRequest(new Features.Genres.Create.ResultDto(false, res.JoinErrors(), null)),
            true when res.Value!.IsSuccessful => new JsonResult(res.Value),
            _ => BadRequest(res.Value)
        };
    }
}