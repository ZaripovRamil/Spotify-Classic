namespace Models.Entities.ValidationErrors;

public static class AlbumErrors
{
    public const string InvalidReleaseYear = "Invalid release year. Should be a number from 0 to nowadays";
    public const string AuthorNotFound = "Author is not found. Author should be an existing user";
    public const string InvalidPreview = "Something's wrong with album's preview";
    public const string AlbumNotFound = "Album not found. Specified album does not exist";
    public const string AlbumContainsTracks =
        "The requested album contains at least one track. It should be empty for safe delete";
}