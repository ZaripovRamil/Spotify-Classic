namespace Models.DTO.BackToFront.Light;

public class UserLight
{
    public string Id { get; set; }
    public string Name { get; set; }

    public UserLight(User user)
    {
        Id = user.Id;
        Name = user.Name;
    }
}