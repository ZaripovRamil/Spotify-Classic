namespace Models.ValidationErrors;

public static class UserErrors
{
    public const string UserNotFound = "User not found. Specified user does not exist";
    public const string InvalidUsername =
        "Invalid username. Should contain only letters or digits and be more than 4 characters long";

    public const string WeakPassword = "Weak password";
    public const string EmailTaken = "This email is already taken";
    public const string LoginTaken = "This login is already taken";
}