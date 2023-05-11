namespace Models.DTO.BackToFront.Auth;

public class LoginResult
{
    public LoginResult(bool loginSucceeded, string token, string resultMessage)
    {
        IsSuccessful = loginSucceeded;
        Token = token;
        ResultMessage = resultMessage;
    }

    public bool IsSuccessful { get; set; }
    public string Token { get; set; }
    public string ResultMessage { get; set; }
}