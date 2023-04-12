using Database.Services;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController
{
    private readonly IDbUserAccessor _userAccessor;
    private readonly IDbAuthorAccessor _authorAccessor;
    private readonly IAuthorFactory _authorFactory;
    private readonly IDtoCreator _dtoCreator;
    public AuthorController(IDbUserAccessor userAccessor, IDbAuthorAccessor authorAccessor, IDtoCreator dtoCreator, IAuthorFactory authorFactory)
    {
        _userAccessor = userAccessor;
        _authorAccessor = authorAccessor;
        _dtoCreator = dtoCreator;
        _authorFactory = authorFactory;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Create([FromBody]AuthorCreationData aData)
    {
        var author = await _authorFactory.Create(aData);
        if(author == null)
            return new JsonResult(new AuthorCreationResult(AuthorCreationCode.InvalidUser, author));
        await _authorAccessor.Add(new Author(aData.Name, aData.UserId));
        return new JsonResult(new AuthorCreationResult(AuthorCreationCode.Successful, author));
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