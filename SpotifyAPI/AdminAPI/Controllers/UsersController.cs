using DatabaseServices.Services.Repositories.Implementations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Light;
using Models.Entities.Enums;

namespace AdminAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController
{
    private readonly IDbSupportChatHistoryRepository _historyRepository;
    private readonly IUserRepository _userRepository;

    public UsersController(IDbSupportChatHistoryRepository historyRepository, IUserRepository userRepository)
    {
        _historyRepository = historyRepository;
        _userRepository = userRepository;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("get")]
    public IActionResult GetAllRooms()
    {
        var users = _historyRepository.GetAll()
            .GroupBy(m => m.RoomId)
            .AsEnumerable()
            .Select(g => g.MaxBy(m => m.Timestamp))
            .OrderByDescending(m => m!.Timestamp)
            .Select(m => m!.RoomId);
        return new JsonResult(users);
    }
    
    [HttpGet("getUsers")]
    public IActionResult GetAll()
    {
        var users = _userRepository.GetAllUsers().AsEnumerable().Select(u => new UserLight(u));
        return new JsonResult(users);
    }
    
    [HttpPost]
    [Route("promote")]
    public async Task<IActionResult> MakeAdminAsync([FromBody] PromoteToAdminDto dto)
    {
        var isDevelopment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development";
        if (!isDevelopment) return new NotFoundResult();
        var user = await _userRepository.GetByUsernameAsync(dto.Login);
        if (user is null) return new NotFoundResult();
        await _userRepository.SetRoleAsync(user, Role.Admin);
        return new OkResult();
    }
    
    public record PromoteToAdminDto(string Login);
}
