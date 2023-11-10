using Models.DTO.BackToFront.Light;

namespace SearchAPI.Features.GlobalSearch;

public record ResultDto(
    List<TrackLight> Tracks,
    List<AlbumLight> Albums,
    List<AuthorLight> Authors,
    List<PlaylistLight> Playlists
    );