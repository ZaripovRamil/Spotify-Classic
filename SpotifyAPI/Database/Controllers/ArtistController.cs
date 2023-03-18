using Database.Services.Accessors;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.DTO;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class ArtistController
{
    private readonly IDbUserAccessor _dbUserAccessor;
    public ArtistController(IDbUserAccessor dbUserAccessor)
    {
        _dbUserAccessor = dbUserAccessor;
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> Create([FromBody]string userId)
    {
        var user = await _dbUserAccessor.UserById(userId);
        if (user == null) return new JsonResult(ArtistCreationCode.NoSuchUser);
        await _dbUserAccessor.SetRole(user, Role.Artist);
        return new JsonResult(ArtistCreationCode.Successful);
    }
}