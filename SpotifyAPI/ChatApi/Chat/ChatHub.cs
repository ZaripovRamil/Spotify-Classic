using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Chat;

[Authorize]
public class ChatHub : Hub
{
    public async Task SendMessage(ChatMessage message)
    {
        var username = Context.User.Identity.Name;
        message.User = username;
        if (!ChatService.MessageHistory.ContainsKey(username))
        {
            ChatService.MessageHistory[username] = new List<ChatMessage>();
        }
        ChatService.MessageHistory[username].Add(message);

        await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", message);
        message.IsOwner = false;
        await Clients.GroupExcept(username,Context.ConnectionId).SendAsync("ReceiveMessage", message);

    }
    
    public async Task AddToGroup()
    {
        var username = Context.User.Identity.Name;
        await Groups.AddToGroupAsync(Context.ConnectionId, username);
    }
}