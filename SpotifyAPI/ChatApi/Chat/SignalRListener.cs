using ChatApi.Dto;
using ChatApi.Features;
using Microsoft.AspNetCore.SignalR;

namespace ChatApi.Chat;

public class SignalRListener : IChatListener
{
    public SignalRListener(ISingleClientProxy client, string connectionId)
    {
        _client = client;
        _connectionId = connectionId;
    }

    private readonly ISingleClientProxy _client;
    private readonly string _connectionId;
    
    public async Task ConsumeMessage(ChatMessage message)
    {
        await _client.SendAsync("ReceiveMessage", message);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is not SignalRListener listener) return false;
        return _connectionId == listener._connectionId;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_client, _connectionId);
    }
}