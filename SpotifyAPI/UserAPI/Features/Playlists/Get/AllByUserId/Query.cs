using Models.DTO.Full;
using Utils.CQRS;

namespace UserAPI.Features.Playlists.Get.AllByUserId;

public record Query(string UserId) : IQuery<IEnumerable<PlaylistFull>>;