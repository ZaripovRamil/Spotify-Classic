using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;

namespace DatabaseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController
{
    private readonly IDbAuthorAccessor _authorAccessor;
    private readonly IAuthorFactory _authorFactory;
    private readonly IDtoCreator _dtoCreator;

    public AuthorController(IDbAuthorAccessor authorAccessor, IDtoCreator dtoCreator,
        IAuthorFactory authorFactory)
    {
        _authorAccessor = authorAccessor;
        _dtoCreator = dtoCreator;
        _authorFactory = authorFactory;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> ProcessAuthorCreation([FromBody] AuthorCreationData data)
    {
        var (state, author) = await _authorFactory.Create(data);
        if (state == AuthorValidationCode.Successful) await _authorAccessor.Add(author!);
        return new JsonResult(new AuthorCreationResult(state, author));
    }

    [HttpGet]
    [Route("get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _authorAccessor.GetById(id)));
    }

    [HttpGet]
    [Route("get/name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _authorAccessor.GetByName(name)));
    }
}