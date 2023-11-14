using UserAPI.Dto;
using Utils.CQRS;

namespace UserAPI.Features.Playlists.AddTracks;

public record Command(string PlaylistId, List<string> TrackIds, string AdderUserId) : ICommand<ResultDto>;