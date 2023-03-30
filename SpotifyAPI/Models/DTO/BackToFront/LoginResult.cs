using Models.DTO.BackToFront.Light;
using Models.Entities;

namespace Models.DTO.BackToFront;

public class LoginResult
{
    public LoginResult(bool loginSucceeded, User user)
    {
        IsSuccessful = loginSucceeded;
        User = new UserLight(user);
    }

    public bool IsSuccessful { get; set; }
    public UserLight User{ get; set; }
}