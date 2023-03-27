using Database.Services.Accessors;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Models.DTO.BackToFront.Full;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController
{
   
    private readonly IDbUserAccessor _dbUserAccessor;

    public UserController(IDbUserAccessor dbUserAccessor)
    {
        _dbUserAccessor = dbUserAccessor;
    }

    [HttpGet]
    [Route("get/username/{username}")]
    public async Task<IActionResult> GetByUsername(string username)
    {
        var user =  await _dbUserAccessor.GetByUsername(username);
        return new JsonResult(user == null ? null : new UserFull(user));
    }

    [HttpGet]
    [Route("get/email/{email}")]
    public async Task<IActionResult> GetByEmail(string email)
    {
        var user =  await _dbUserAccessor.GetByEmail(email);
        return new JsonResult(user == null ? null : new UserFull(user));
    }

    [HttpGet]
    [Route("get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var user =  await _dbUserAccessor.GetById(id);
        return new JsonResult(user == null ? null : new UserFull(user));
    }
}