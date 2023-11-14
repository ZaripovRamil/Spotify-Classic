using Models.DTO.Full;
using Utils.CQRS;

namespace AdminAPI.Features.Tracks.Get.ById;

public record Query(string Id) : IQuery<TrackFull>;