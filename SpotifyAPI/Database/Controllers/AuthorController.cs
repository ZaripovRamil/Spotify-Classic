using Database.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Models.DTO.BackToFront.EntityCreationResult;
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
    [Route("create")]
    public async Task<IActionResult> Create([FromBody]AuthorCreationData aData)
    {
        var user = await _dbUserAccessor.GetById(aData.UserId);
        if (user == null) return new JsonResult(AuthorCreationCode.NoSuchUser);
        await _dbAuthorAccessor.Add(new Author(aData.Name, aData.UserId));
        return new JsonResult(AuthorCreationCode.Successful);
    }
    //TODO:GetByName|Id
}