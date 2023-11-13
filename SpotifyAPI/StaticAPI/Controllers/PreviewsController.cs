using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace StaticAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PreviewsController : Controller
{
    
    private readonly IMediator _mediator;

    public PreviewsController(IMediator mediator)
    {
        _mediator = mediator;
    }


    // TO DO: change this to receive the whole path to the file, not just id
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var q = new Features.Preview.GetById.Query(id);
        var res = await _mediator.Send(q);
        return res.IsSuccessful ? File(res.Value!, "application/octet-stream", $"{id}.jpg"): NotFound(res.JoinErrors());
    }
    
    [HttpPost("upload")]
    public async Task<IActionResult> UploadFileAsync([FromForm] IFormFile? file)
    {
        var c = new Features.Preview.UploadFile.Command(file);
        var res = await _mediator.Send(c);
        return res.IsSuccessful ? Ok() : BadRequest(res.JoinErrors());
    }
}