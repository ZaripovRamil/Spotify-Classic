using Database.Services.Accessors;
using Database.Services.Factories;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController
{
    private readonly IUserFactory _userFactory;
    private readonly IDbUserAccessor _dbUserAccessor;

    public UserController(IUserFactory factory, IDbUserAccessor dbUserAccessor)
    {
        _userFactory = factory;
        _dbUserAccessor = dbUserAccessor;
    }

    [HttpPost]
    [Route("Add")]
    public async void Add([FromBody] RegistrationData rData)
    {
        await _dbUserAccessor.AddUser(_userFactory.Create(rData));
    }

    [HttpGet]
    [Route("get/login/{login}")]
    public async Task<IActionResult> GetByLogin(string login)
    {
        return new JsonResult(await _dbUserAccessor.UserByLogin(login));
    }

    [HttpGet]
    [Route("get/email/{email}")]
    public async Task<IActionResult> GetByEmail(string email)
    {
        return new JsonResult(await _dbUserAccessor.UserByEmail(email));
    }

    [HttpGet]
    [Route("get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return new JsonResult(await _dbUserAccessor.UserById(id));
    }
}