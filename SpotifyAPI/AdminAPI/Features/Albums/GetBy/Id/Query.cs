using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.GetBy.Id;

public record Query(string Id) : IQuery<AlbumFull>;