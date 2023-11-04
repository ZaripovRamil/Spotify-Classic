using DatabaseServices.Infrastructure.Specs;
using Models.Entities;

namespace SearchAPI.Features.GlobalSearch;

public static class TrackSpec
{
    public static Specification<Track> NameContains(string filter) =>
        new(t => t.Name.ToLower().Contains(filter.ToLower()));
}

public static class AlbumSpec
{
    public static Specification<Album> NameContains(string filter) =>
        new(a => a.Name.ToLower().Contains(filter.ToLower()));
}

public static class AuthorSpec
{
    public static Specification<Author> NameContains(string filter) =>
        new(a => a.Name.ToLower().Contains(filter.ToLower()));
}

public static class PlaylistSpec
{
    public static Specification<Playlist> NameContains(string filter) =>
        new(p => p.Name.ToLower().Contains(filter.ToLower()));
}