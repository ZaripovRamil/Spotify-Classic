using Database.Services.Accessors;
using Database.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;

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
        var genre =  await _genreAccessor.GetById(id);
        return new JsonResult(genre == null ? null : new GenreLight(genre));
    }
    
    [HttpGet]
    [Route("get/name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var genre =  await _genreAccessor.GetById(name);
        return new JsonResult(genre == null ? null : new GenreLight(genre));
    }
}