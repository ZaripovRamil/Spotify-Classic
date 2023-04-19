using Database.Services;
using Database.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController
{
    private readonly IDbUserAccessor _userAccessor;
    private readonly IDbAuthorAccessor _authorAccessor;
    private readonly IDtoCreator _dtoCreator;
    public AuthorController(IDbUserAccessor userAccessor, IDbAuthorAccessor authorAccessor, IDtoCreator dtoCreator)
    {
        _userAccessor = userAccessor;
        _authorAccessor = authorAccessor;
        _dtoCreator = dtoCreator;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Create([FromBody]AuthorCreationData aData)
    {
        var user = await _userAccessor.GetById(aData.UserId);
        if (user == null) return new JsonResult(AuthorCreationCode.NoSuchUser);
        await _authorAccessor.Add(new Author(aData.Name, aData.UserId));
        return new JsonResult(AuthorCreationCode.Successful);
    }

    [HttpGet]
    [Route("Get")]
    public Task<IActionResult> GetAllAsync()
    {
        var authors = _authorAccessor
            .GetAll()
            .Select(author => new AuthorLight(author));
        return Task.FromResult<IActionResult>(new JsonResult(authors));
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