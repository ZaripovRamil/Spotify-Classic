using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Chat;

[Authorize]
public class ChatHub : Hub
{
    public override async Task OnConnectedAsync()
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, Context.User.Identity.Name);
        await base.OnConnectedAsync();
    }

    public async Task SendMessage(ChatMessage message)
    {
        var username = Context.User.Identity.Name;
        message.User = username;
        await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", message);
        message.IsOwner = false; 
        await Clients.GroupExcept(username,Context.ConnectionId).SendAsync("ReceiveMessage", message);
        
        /*var username = Context.User.Identity.Name;
        message.User = username;
        await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", message);
        message.IsOwner = false; 
        await Clients.AllExcept(Context.ConnectionId).SendAsync("ReceiveMessage", message);*/
    }
}