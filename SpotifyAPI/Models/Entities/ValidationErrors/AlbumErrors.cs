namespace Models.Entities.ValidationErrors;

public static class AlbumErrors
{
    public const string InvalidReleaseYear = "Invalid release year! Should be a number from 0 to nowadays";
    public const string InvalidAuthor = "Invalid author. Author should be registered in the system";
    public const string InvalidPreview = "Something's wrong with album's preview";
}