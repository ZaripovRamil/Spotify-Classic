using DatabaseServices.Infrastructure.Specs;
using Models.Entities;

namespace SearchAPI.Features.SearchAuthorsByUser;

public static class Spec
{
    public static Specification<Author> NameContains(string filter) =>
        new(a => a.User.Name.ToLower().Contains(filter.ToLower()));

    public static Specification<Author> UserNameExists() => new(a => a.User.UserName != null);

    public static Specification<Author> UserNameContains(string filter) =>
        UserNameExists() &&
        new Specification<Author>(a => a.User.UserName!.ToLower().Contains(filter.ToLower()));
}