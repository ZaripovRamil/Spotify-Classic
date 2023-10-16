using DatabaseServices.Services.Accessors.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Controllers;

[ApiController]
[Route("chat")]
[Authorize]
public class ChatController : Controller
{
    private readonly IDbSupportChatHistoryAccessor _historyAccessor;

    public ChatController(IDbSupportChatHistoryAccessor historyAccessor)
    {
        _historyAccessor = historyAccessor;
    }

    [HttpGet("[action]")]
    public List<ChatMessage> History()
    {
        var username = User.Identity!.Name!;
        return _historyAccessor.GetHistoryForUserId(username).Select(sm => new ChatMessage
        {
            Message = sm.Message,
            User = sm.IsOwner ? username : "Admin",
            Timestamp = sm.Timestamp,
            IsOwner = sm.IsOwner
        })
            .OrderBy(m => m.Timestamp)
            .ToList();
    }
    
    [Authorize(Roles = "Admin")]
    [HttpGet("[action]/{groupname}")]
    public List<ChatMessage> History(string groupname)
    {
        var history = _historyAccessor.GetHistoryForUserId(groupname).Select(sm => new ChatMessage()
        {
            Message = sm.Message,
            User = sm.IsOwner ? sm.Sender.UserName! : $"Admin({sm.Sender.UserName!})",
            Timestamp = sm.Timestamp,
            IsOwner = sm.IsOwner
        })
            .OrderBy(m => m.Timestamp)
            .ToList();
        return history;
    }
}