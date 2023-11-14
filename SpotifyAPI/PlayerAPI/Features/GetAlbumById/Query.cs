using Models.DTO.Full;
using Utils.CQRS;

namespace PlayerAPI.Features.GetAlbumById;

public record Query(string Id) : IQuery<AlbumFull>;