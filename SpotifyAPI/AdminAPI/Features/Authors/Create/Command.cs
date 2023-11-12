using Utils.CQRS;

namespace AdminAPI.Features.Authors.Create;

public record Command(string UserId, string Name) : ICommand<ResultDto>;