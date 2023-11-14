using Models.DTO.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Get.ById;

public record Query(string Id) : IQuery<AlbumFull>;