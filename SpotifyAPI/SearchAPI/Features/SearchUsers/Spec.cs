using DatabaseServices.Infrastructure.Specs;
using Models.Entities;

namespace SearchAPI.Features.SearchUsers;

public class Spec
{
    public static Specification<User> NameContains(string filter) =>
        new(u => u.Name.ToLower().Contains(filter.ToLower()));

    public static Specification<User> UserNameExists() => new(u => u.UserName != null);

    public static Specification<User> UserNameContains(string filter) =>
        UserNameExists() &&
        new Specification<User>(u => u.UserName!.ToLower().Contains(filter.ToLower()));
}