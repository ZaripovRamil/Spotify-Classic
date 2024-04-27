using Models.DTO.Light;

namespace Models.DTO.Search;

public record SearchResult(
    List<TrackLight> Tracks,
    List<AlbumLight> Albums,
    List<AuthorLight> Authors,
    List<PlaylistLight> Playlists
    );