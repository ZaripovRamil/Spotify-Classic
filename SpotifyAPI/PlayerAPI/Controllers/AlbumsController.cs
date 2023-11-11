using DatabaseServices.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;

namespace PlayerAPI.Controllers;

[Authorize(Roles = "Free,Premium,Admin")]
[ApiController]
[Route("[controller]")]
public class AlbumsController : Controller
{
    private readonly IAlbumRepository _albumRepository;

    public AlbumsController(IAlbumRepository albumRepository)
    {
        _albumRepository = albumRepository;
    }

    [HttpGet("get")]
    public IActionResult GetAll()
    {
        return new JsonResult(_albumRepository.GetAll().AsEnumerable().Select(a => new AlbumLight(a)));
    }

    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetByIdAsync(string id)
    {
        var album = await _albumRepository.GetByIdAsync(id);
        return album is null ? new JsonResult(null) : new JsonResult(new AlbumLight(album));
    }
}