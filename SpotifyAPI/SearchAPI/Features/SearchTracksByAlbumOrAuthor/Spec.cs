using DatabaseServices.Infrastructure.Specs;
using Models.Entities;

namespace SearchAPI.Features.SearchTracksByAlbumOrAuthor;

public static class Spec
{
    public static Specification<Track> AlbumNameContains(string filter) =>
        new(t => t.Album.Name.ToLower().Contains(filter.ToLower()));

    public static Specification<Track> AuthorNameContains(string filter) =>
        new(t => t.Album.Author.Name.ToLower().Contains(filter.ToLower()));
}