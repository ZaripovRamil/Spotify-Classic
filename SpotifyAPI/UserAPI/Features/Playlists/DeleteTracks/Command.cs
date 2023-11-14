using UserAPI.Dto;
using Utils.CQRS;

namespace UserAPI.Features.Playlists.DeleteTracks;

public record Command(string PlaylistId, List<string> TrackIds, string DeleterUserId) : ICommand<ResultDto>;