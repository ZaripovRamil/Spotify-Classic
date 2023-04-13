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
    public async Task<IActionResult> ProcessGenreCreation(GenreCreationData data)
    {
        return new JsonResult(new GenreCreationResult(await CreateGenre(data)));
    }

    private async Task<(GenreCreationCode, Genre)> CreateGenre(GenreCreationData data)
    {
        if (await _genreAccessor.GetByName(data.Name)!=null) return (GenreCreationCode.AlreadyExists, null);
        var genre = new Genre(data.Name);
        return (GenreCreationCode.Successful, genre);
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