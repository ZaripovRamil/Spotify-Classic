using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront;

public class UsersSearchResult
{
    public UsersSearchResult(List<UserLight> users)
    {
        Users = users;
    }
    
    public List<UserLight> Users { get; set; }
}