using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ChatUsersController : Controller
{
    private readonly IDbSupportChatHistoryAccessor _historyAccessor;

    public ChatUsersController(IDbSupportChatHistoryAccessor historyAccessor)
    {
        _historyAccessor = historyAccessor;
    }

    [HttpGet("getAllRooms")]
    public IActionResult GetAllRoomsAsync()
    {
        return new JsonResult(_historyAccessor.GetAll()
            .GroupBy(m => m.RoomId)
            .AsEnumerable()
            .Select(g => g.MaxBy(m => m.Timestamp))
            .OrderByDescending(m => m!.Timestamp)
            .Select(m => m!.RoomId));
    }
}