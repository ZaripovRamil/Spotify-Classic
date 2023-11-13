using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace PlayerAPI.Features.GetPlaylistById;

public record Query(string Id) : IQuery<PlaylistFull>;