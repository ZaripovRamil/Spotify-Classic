using Utils.CQRS;

namespace PlayerAPI.Features.GetTracks;

public record Query() : IQuery<ResultDto>;