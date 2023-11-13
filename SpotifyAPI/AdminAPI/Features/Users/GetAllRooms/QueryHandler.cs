using DatabaseServices.Repositories;
using Utils.CQRS;

namespace AdminAPI.Features.Users.GetAllRooms;

public class QueryHandler : IQueryHandler<Query, IEnumerable<string>>
{
    private readonly ISupportChatHistoryRepository _historyRepository;

    public QueryHandler(ISupportChatHistoryRepository historyRepository)
    {
        _historyRepository = historyRepository;
    }

    public Task<Result<IEnumerable<string>>> Handle(Query request, CancellationToken cancellationToken)
    {
        var users = _historyRepository.GetAllAsync().ToEnumerable()
            .GroupBy(m => m.RoomId)
            .Select(g => g.MaxBy(m => m.Timestamp))
            .OrderByDescending(m => m!.Timestamp)
            .Select(m => m!.RoomId);
        return Task.FromResult(new Result<IEnumerable<string>>(value: users));
    }
}