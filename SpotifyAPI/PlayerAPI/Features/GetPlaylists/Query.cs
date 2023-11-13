using Utils.CQRS;

namespace PlayerAPI.Features.GetPlaylists;

public record Query() : IQuery<ResultDto>;