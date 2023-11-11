using DatabaseServices.Infrastructure.Specs;
using Models.Entities;

namespace SearchAPI.Features.SearchAlbums;

public static class Spec
{
    public static Specification<Album> NameContains(string filter) =>
        new(a => a.Name.ToLower().Contains(filter.ToLower()));
}