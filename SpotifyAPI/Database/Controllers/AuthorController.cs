using Database.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;
using Models.DTO.BackToFront.EntityCreationResult;

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
    public async Task<IActionResult> Create([FromBody]string userId)
    {
        var user = await _dbUserAccessor.GetById(userId);
        if (user == null) return new JsonResult(AuthorCreationCode.NoSuchUser);
        
        return new JsonResult(AuthorCreationCode.Successful);
    }
}