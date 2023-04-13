using Database.Services;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class GenreController
{
    private readonly IDbGenreAccessor _genreAccessor;
    private readonly IDtoCreator _dtoCreator;
    private readonly IGenreFactory _genreFactory;

    public GenreController(IDbGenreAccessor genreAccessor, IDtoCreator dtoCreator, IGenreFactory genreFactory)
    {
        _genreAccessor = genreAccessor;
        _dtoCreator = dtoCreator;
        _genreFactory = genreFactory;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> ProcessGenreCreation(GenreCreationData data)
    {
        var (state, genre) = await _genreFactory.Create(data);
        if (state == GenreCreationCode.Successful) await _genreAccessor.Add(genre!);
        return new JsonResult(new GenreCreationResult(state, genre));
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