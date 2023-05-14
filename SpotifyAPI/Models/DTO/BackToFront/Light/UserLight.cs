using Models.Entities;

namespace Models.DTO.BackToFront.Light;

public class UserLight
{
    public string Id { get; set; }
    public string ProfilePicId { get; set; }
    public string Name { get; set; }

    public UserLight(User user)
    {
        Id = user.Id;
        ProfilePicId = user.ProfilePicId;
        Name = user.Name;
    }

    public UserLight() { }
}