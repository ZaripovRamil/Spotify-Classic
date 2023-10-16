using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Entities.Enums;

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

    [HttpGet]
    [Route("getAll")]
    public Task<JsonResult> GetAllUsers()
    {
        var users = _userAccessor.GetAllUsers().Select(user => _dtoCreator.CreateLight(user)).ToList();
        return Task.FromResult(new JsonResult(users));
    }

    [HttpPost]
    [Route("promote")]
    public async Task<IActionResult> MakeAdminAsync([FromBody] PromoteToAdminDto dto)
    {
        var user = await _userAccessor.GetByUsername(dto.login);
        if (user is null) return new NotFoundResult();
        await _userAccessor.SetRole(user, Role.Admin);
        return new OkResult();
    }
    
    public record PromoteToAdminDto(string login);
}