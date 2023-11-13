using DatabaseServices.Repositories;
using Microsoft.EntityFrameworkCore;
using Models.DTO.FrontToBack.Chat;
using Utils.CQRS;

namespace ChatApi.Features.AdminChatHistory;

public class QueryHandler: IQueryHandler<Query,ResultDto>
{
    private readonly ISupportChatHistoryRepository _historyRepository;
    
    public QueryHandler(ISupportChatHistoryRepository historyRepository)
    {
        _historyRepository = historyRepository;
    }
    
    public async Task<Result<ResultDto>> Handle(Query request, CancellationToken cancellationToken)
    {
        return new ResultDto(
            await _historyRepository
                .GetHistoryForUserId(request.GroupName)
                .Select(sm => new ChatMessage()
                    {
                        Message = sm.Message,
                        User = sm.IsOwner ? sm.Sender.UserName! : $"Admin({sm.Sender.UserName!})",
                        Timestamp = sm.Timestamp,
                        IsOwner = sm.IsOwner
                    })
                .OrderBy(m => m.Timestamp)
                .ToListAsync(cancellationToken: cancellationToken));
    }
}