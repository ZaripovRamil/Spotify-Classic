using System.Collections.Concurrent;
using ChatApi.Dto;

namespace ChatApi.Features.MobileChat;

public class GrpcListener : IChatHandler
{
    private readonly ConcurrentQueue<ChatMessage> _queue = new();
    private readonly Guid _connectionId;

    public GrpcListener(Guid connectionId)
    {
        _connectionId = connectionId;
    }

    public Task ConsumeMessage(ChatMessage message)
    {
        _queue.Enqueue(message);
        return Task.CompletedTask;
    }

    public IEnumerable<ChatMessage> ReadMessages()
    {
        while (!_queue.IsEmpty)
        {
            var ok = _queue.TryDequeue(out var res);
            if (!ok) break;
            yield return res!;
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is not GrpcListener listener) return false;
        return _connectionId == listener._connectionId;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_queue, _connectionId);
    }
}