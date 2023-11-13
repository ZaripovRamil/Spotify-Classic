using Utils.CQRS;

namespace ChatApi.Features.AdminChatHistory;

public record Query(string GroupName) : IQuery<ResultDto>;