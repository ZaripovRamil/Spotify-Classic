using Models.Entities;

namespace Models.DTO.Light;

public class UserLight
{
    public string Id { get; set; } = default!;
    public string ProfilePicId { get; set; } = default!;
    public string Name { get; set; } = default!;

    public string? UserName { get; set; }

    public UserLight(User user)
    {
        Id = user.Id;
        ProfilePicId = user.ProfilePicId;
        Name = user.Name;
        UserName = user.UserName;
    }

    public UserLight()
    {
    }
}