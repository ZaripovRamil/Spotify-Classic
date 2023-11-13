using Utils.CQRS;
namespace ChatApi.Features.UserChatHistory;

public record Query(string GroupName) : IQuery<ResultDto>;
