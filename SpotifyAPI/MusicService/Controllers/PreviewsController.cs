using Microsoft.AspNetCore.Mvc;
using MusicService.Services;

namespace MusicService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PreviewsController : Controller
{
    private readonly IFileProvider _fileProvider;
    
    public PreviewsController(IFileProvider fp)
    {
        _fileProvider = fp;
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var preview = _fileProvider.GetFileAsStream($"Assets/Previews/{id}.jpg");
        Response.ContentLength = _fileProvider.GetFileLength($"Assets/Previews/{id}.jpg");
        if (preview is null) return NotFound();
        return File(preview, "application/octet-stream", $"{id}.jpg");
    }
}