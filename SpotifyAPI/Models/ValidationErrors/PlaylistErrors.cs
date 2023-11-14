namespace Models.ValidationErrors;

public static class PlaylistErrors
{
    public const string PlaylistNotFound = "Playlist not found. Specified playlist does not exist";
    public const string OwnerDoesNotExist = "Playlist owner does not exist";
    public const string OwnerDoesNotMatch = "Unable to delete other user's playlist";
}