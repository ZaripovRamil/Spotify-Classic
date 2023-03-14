using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;
using Models.DTO;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController
{
    private readonly AppDbContext _dbContext;
    private readonly IUserFactory _userFactory;
    private async Task<User?> UserByLogin(string login)=>
        await _dbContext.Users.FirstOrDefaultAsync(u => u.Login == login);
    private async Task<User?> UserByEmail(string email) => 
        await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
    public UserController(AppDbContext dbContext, IUserFactory factory)
    {
        _dbContext = dbContext;
        _userFactory = factory;
    }

    [HttpPost]
    [Route("Add")]
    public async void Add([FromBody]RegistrationData rData)
    {
        await _dbContext.Users.AddAsync(_userFactory.Create(rData));
        await _dbContext.SaveChangesAsync();
    }

    [HttpGet]
    [Route("get/login/{login}")]
    public async Task<IActionResult> GetByLogin(string login)
    {
        return new JsonResult(await UserByLogin(login));
    }

    [HttpGet]
    [Route("get/email/{email}")]
    public async Task<IActionResult> GetByEmail(string email)
    {
        return new JsonResult(await UserByEmail(email));
    }
}