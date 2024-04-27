using Models.DTO.Albums;
using Utils.CQRS;

namespace PlayerAPI.Features.GetAlbums;

public record Query: IQuery<AlbumsResult>;