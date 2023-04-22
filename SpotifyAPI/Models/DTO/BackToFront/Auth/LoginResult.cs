using Models.Entities;

namespace Models.DTO.BackToFront.Auth;

public class LoginResult
{
    public LoginResult(bool loginSucceeded, User user)
    {
        IsSuccessful = loginSucceeded;
        UserId = user.Id;
    }

    public bool IsSuccessful { get; set; }
    public string UserId { get; set; }
}