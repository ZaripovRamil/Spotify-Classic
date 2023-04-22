using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController
{
    private readonly IDbUserAccessor _userAccessor;
    private readonly IDtoCreator _dtoCreator;

    public UserController(IDbUserAccessor userAccessor, IDtoCreator dtoCreator)
    {
        _userAccessor = userAccessor;
        _dtoCreator = dtoCreator;
    }

    [HttpGet]
    [Route("get/username/{username}")]
    public async Task<IActionResult> GetByUsername(string username)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _userAccessor.GetByUsername(username)));
    }

    [HttpGet]
    [Route("get/email/{email}")]
    public async Task<IActionResult> GetByEmail(string email)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _userAccessor.GetByEmail(email)));
    }

    [HttpGet]
    [Route("get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _userAccessor.GetById(id)));
    }
}