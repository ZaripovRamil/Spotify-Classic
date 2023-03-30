using Database.Services;
using Database.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController
{
    private readonly IDbGenreAccessor _genreAccessor;
    private readonly IDtoCreator _dtoCreator;

    public GenreController(IDbGenreAccessor genreAccessor, IDtoCreator dtoCreator)
    {
        _genreAccessor = genreAccessor;
        _dtoCreator = dtoCreator;
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
        return new JsonResult(_dtoCreator.CreateLight(await _genreAccessor.GetById(id)));
    }
    
    [HttpGet]
    [Route("get/name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        return new JsonResult(_dtoCreator.CreateLight(await _genreAccessor.GetByName(name)));
    }
}