namespace Models.ValidationErrors;

public static class TrackErrors
{
    public const string InvalidTrackFile = "Something's wrong with track's file content";
    public const string TrackNotFound = "Track not found. Specified track does not exist";
    public const string InvalidGenre = "Specified genre is invalid. All the genres should exist";
}