
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
        
        AddMessageToHistory(username,message);

        await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", message);
        message.IsOwner = false;
        await Clients.GroupExcept(username,Context.ConnectionId).SendAsync("ReceiveMessage", message);
    }

    public async Task AddToGroup()
    {
        var username = Context.User.Identity.Name;
        await Groups.AddToGroupAsync(Context.ConnectionId, username);
    }
    
    [Authorize(Roles = "Admin")]
    public async Task SendAdminMessage(ChatMessage message)
    {
        message.User = "Admin";
        var groupname = message.GroupName;
        
        AddMessageToHistory(groupname,message);

        await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", message);
        message.IsOwner = false;
        await Clients.GroupExcept(groupname,Context.ConnectionId).SendAsync("ReceiveMessage", message);
    }
    
    [Authorize(Roles = "Admin")]
    public async Task AddToGroupByName(string groupname)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, groupname);
    }

    private void AddMessageToHistory(string groupname, ChatMessage message)
    {
        if (!ChatService.MessageHistory.ContainsKey(groupname))
        {
            ChatService.MessageHistory[groupname] = new List<ChatMessage>();
        }
        ChatService.MessageHistory[groupname].Add(message);
    }
}