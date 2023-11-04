using DatabaseServices.Infrastructure.Specs;
using Models.Entities;

namespace SearchAPI.Features.SearchAlbumsByAuthor;

public static class Spec
{
    public static Specification<Album> AuthorNameContains(string filter) =>
        new(a => a.Author.Name.ToLower().Contains(filter.ToLower()));
}