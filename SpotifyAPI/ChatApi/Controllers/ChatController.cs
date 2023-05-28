using ChatApi.Chat;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Controllers;

[ApiController]
[Route("chat")]
[Authorize]
public class ChatController : Controller
{
    private readonly IHubContext<ChatHub> _hubCnt;

    [HttpGet("[action]")]
    public async Task<List<ChatMessage>> History()
    {
        var username = User.Identity.Name;
        if (!ChatService.MessageHistory.ContainsKey(username))
        {
            ChatService.MessageHistory[username] = new List<ChatMessage>();
        }
        var history = ChatService.MessageHistory[username].Select(m => new ChatMessage()
        {
            Message = m.Message,
            User = m.User,
            IsOwner = m.User == username
        }).ToList();
        return history;
    }
    
    [Authorize(Roles = "Admin")]
    [HttpGet("[action]/{groupname}")]
    public async Task<List<ChatMessage>> History(string groupname)
    {
        if (!ChatService.MessageHistory.ContainsKey(groupname))
        {
            ChatService.MessageHistory[groupname] = new List<ChatMessage>();
        }
        var history = ChatService.MessageHistory[groupname].Select(m => new ChatMessage()
        {
            Message = m.Message,
            User = m.User,
            IsOwner = m.User != groupname
        }).ToList();
        return history;
    }
}