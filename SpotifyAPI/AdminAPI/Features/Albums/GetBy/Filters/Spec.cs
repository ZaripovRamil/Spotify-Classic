using DatabaseServices.Infrastructure.Specs;
using Models.Entities;
using Models.Entities.Enums;

namespace AdminAPI.Features.Albums.GetBy.Filters;

public static class Spec
{
    private static Specification<Album> HasAnyType => new(a => true);

    public static Specification<Album> OfType(string? type) =>
        type is null ? HasAnyType : new Specification<Album>(a => a.Type == Enum.Parse<AlbumType>(type));

    public static Specification<Album> HasTracksNoLessThan(int? c) => new(a => c == null || a.Tracks.Count >= c);
    
    public static Specification<Album> HasTracksNoMoreThan(int? c) => new(a => c == null || a.Tracks.Count <= c);
    
    public static Specification<Album> ContainsTextInName(string? text) =>
        new(a => text == null || a.Name.ToLower().Contains(text.ToLower()));
}