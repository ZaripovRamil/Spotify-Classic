using Models.DTO.BackToFront.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Get.ById;

public record Query(string Id) : IQuery<AlbumFull>;