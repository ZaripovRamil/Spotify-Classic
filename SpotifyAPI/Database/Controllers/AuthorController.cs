using Database.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Full;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorController
{
    private readonly IDbUserAccessor _dbUserAccessor;
    private readonly IDbAuthorAccessor _dbAuthorAccessor;
    public AuthorController(IDbUserAccessor dbUserAccessor, IDbAuthorAccessor dbAuthorAccessor)
    {
        _dbUserAccessor = dbUserAccessor;
        _dbAuthorAccessor = dbAuthorAccessor;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> Create([FromBody]AuthorCreationData aData)
    {
        var user = await _dbUserAccessor.GetById(aData.UserId);
        if (user == null) return new JsonResult(AuthorCreationCode.NoSuchUser);
        await _dbAuthorAccessor.Add(new Author(aData.Name, aData.UserId));
        return new JsonResult(AuthorCreationCode.Successful);
    }
    
    [HttpGet]
    [Route("get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var author =  await _dbAuthorAccessor.GetById(id);
        return new JsonResult(author == null ? null : new AuthorFull(author));
    }
    
    [HttpGet]
    [Route("get/name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var author =  await _dbAuthorAccessor.GetByName(name);
        return new JsonResult(author == null ? null : new AuthorFull(author));
    }
}