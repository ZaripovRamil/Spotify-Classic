
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Models.DTO.FrontToBack.Chat;

namespace ChatApi.Chat;

[Authorize]
public class ChatHub : Hub
{
    private static Dictionary<string,string> ActiveAdminConnections = new Dictionary<string, string>();
    private static List<string> ConnectedAdminGroups= new List<string>();
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
        foreach (var group in ConnectedAdminGroups)
        {
            await Groups.RemoveFromGroupAsync(ActiveAdminConnections[group], group);
        }

        ConnectedAdminGroups = new List<string>();
        ActiveAdminConnections[groupname] = Context.ConnectionId;
        ConnectedAdminGroups.Add(groupname);
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