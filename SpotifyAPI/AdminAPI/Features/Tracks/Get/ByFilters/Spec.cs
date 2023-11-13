using DatabaseServices.Infrastructure.Specs;
using Models.Entities;

namespace AdminAPI.Features.Tracks.Get.ByFilters;

public static class Spec
{
    public static Specification<Track> ContainsTextInName(string? text) =>
        new(a => text == null || a.Name.ToLower().Contains(text.ToLower()));
}