namespace Models.Entities.ValidationErrors;

public static class AuthorErrors
{
    public const string UserNotFound = "User not found. Specified user does not exist";
    public const string AuthorNotFound = "Author with specified id not found";
    public const string AuthorHasAlbums =
        "Specified author has at least one album. There should be no albums for safe delete";
}