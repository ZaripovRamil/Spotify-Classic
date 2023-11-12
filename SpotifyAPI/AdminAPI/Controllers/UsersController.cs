using DatabaseServices.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;
using Models.Entities.Enums;

namespace AdminAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController
{
    private readonly ISupportChatHistoryRepository _historyRepository;
    private readonly IUserRepository _userRepository;

    public UsersController(ISupportChatHistoryRepository historyRepository, IUserRepository userRepository)
    {
        _historyRepository = historyRepository;
        _userRepository = userRepository;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("get")]
    public IActionResult GetAllRooms()
    {
        var users = _historyRepository.GetAllAsync().ToEnumerable()
            .GroupBy(m => m.RoomId)
            .Select(g => g.MaxBy(m => m.Timestamp))
            .OrderByDescending(m => m!.Timestamp)
            .Select(m => m!.RoomId);
        return new JsonResult(users);
    }

    [HttpGet("getUsers")]
    public async Task<IActionResult> GetAllAsync()
    {
        var users = await _userRepository.GetAllAsync().Select(u => new UserLight(u)).ToListAsync();
        return new JsonResult(users);
    }

    [HttpPost]
    [Route("promote")]
    public async Task<IActionResult> MakeAdminAsync([FromBody] string login)
    {
        var isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
        if (!isDevelopment) return new NotFoundResult();
        var user = await _userRepository.GetByNameAsync(login);
        if (user is null) return new NotFoundResult();
        await _userRepository.SetRoleAsync(user, Role.Admin);
        return new OkResult();
    }
}