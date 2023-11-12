using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.GetById;

public record Query(string Id) : IQuery<AlbumFull>;