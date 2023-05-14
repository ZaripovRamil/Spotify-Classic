using Microsoft.AspNetCore.Mvc;
using StaticAPI.Services;

namespace StaticAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PreviewsController : Controller
{
    private readonly IFileProvider _fileProvider;

    public PreviewsController(IFileProvider fp)
    {
        _fileProvider = fp;
    }

    // TODO: change this to receive the whole path to the file, not just id
    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var preview = _fileProvider.GetFileAsStream("Previews", $"{id}.jpg");
        if (preview is null) return NotFound();
        return File(preview, "application/octet-stream", $"{id}.jpg");
    }
    
    [HttpPost("upload")]
    public async Task<IActionResult> UploadFileAsync([FromForm] IFormFile? file)
    {
        if (file is null || file.Length == 0)
            return BadRequest("Empty file");
        if (file.FileName.Length == 0)
            return BadRequest("Filename is not provided");
        await _fileProvider.UploadAsync("Previews", file.FileName, file.OpenReadStream());
        return Ok();
    }
}