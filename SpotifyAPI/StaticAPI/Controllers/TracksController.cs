using Microsoft.AspNetCore.Mvc;
using StaticAPI.Services;

namespace StaticAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TracksController : Controller
{
    private const string AssetsName = "Assets";
    private readonly IFileProvider _fileProvider;
    private readonly IHlsConverter _hlsConverter;

    public TracksController(IFileProvider fp, IHlsConverter hlsConverter)
    {
        _fileProvider = fp;
        _hlsConverter = hlsConverter;
    }

    // TO DO: change this to receive the whole path to the file, not just id
    [HttpGet("{id:guid}")]
    public Task<IActionResult> DownloadByIdAsync(Guid id)
    {
        var idSplit = id.ToString().Split('.');
        var fileName = Path.Combine(idSplit[0], idSplit.Length > 1 ? id.ToString() : $"{id}.index.m3u8");
        var track = _fileProvider.GetFileAsStream("Tracks", fileName);
        return track is null
            ? Task.FromResult<IActionResult>(NotFound())
            : Task.FromResult<IActionResult>(new FileStreamResult(track, "application/octet-stream"));
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadFileAsync([FromForm] IFormFile? file)
    {
        if (file is null || file.Length == 0)
            return BadRequest("Empty file");
        if (file.FileName.Length == 0)
            return BadRequest("Filename is not provided");
        var fileName = Path.GetFileNameWithoutExtension(file.FileName);
        var trackPath = Path.Combine("Tracks", fileName);
        await _fileProvider.UploadAsync(trackPath, file.FileName, file.OpenReadStream());
        if (!file.FileName.EndsWith(".mp3")) return Ok();
        await _hlsConverter.SaveHlsFromMp3Async(Path.Combine(AssetsName, "Tracks", fileName, file.FileName),
            Path.Combine(AssetsName, trackPath));
        await _fileProvider.DeleteFileAsync(trackPath, file.FileName);

        return Ok();
    }
}