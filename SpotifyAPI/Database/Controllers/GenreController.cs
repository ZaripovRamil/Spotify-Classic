using Database.Services.Accessors;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController
{
    private readonly IDbGenreAccessor _genreAccessor;

    public GenreController(IDbGenreAccessor genreAccessor)
    {
        _genreAccessor = genreAccessor;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Add(GenreCreationData gData)
    {
        var genre = await _genreAccessor.GetByName(gData.Name);
        if (genre != null) return new JsonResult(GenreCreationCode.AlreadyExists);
        await _genreAccessor.Add(new Genre(gData.Name));
        return new JsonResult(GenreCreationCode.Successful);
    }
    
    [HttpGet]
    [Route("get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return new JsonResult(await _genreAccessor.GetById(id));
    }
    
    [HttpGet]
    [Route("get/name/{name}")]
    public async Task<IActionResult> GetByLogin(string name)
    {
        return new JsonResult(await _genreAccessor.GetByName(name));
    }
}