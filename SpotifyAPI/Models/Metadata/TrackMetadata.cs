namespace Models.Metadata;

public class TrackMetadata : Metadata
{
    public uint DurationSeconds { get; set; }
    public string TrackName { get; set; } = default!;
    public string AlbumName { get; set; } = default!;
    public string AuthorName { get; set; } = default!;
    public string TrackId { get; set; } = default!;
    public string AlbumId { get; set; } = default!;
    public string AuthorId { get; set; } = default!;

    public TrackMetadata(){}
    public TrackMetadata(uint duration, string fileId, string fileName, long fileSize, string trackName, string albumName, string authorName, string trackId, string albumId, string authorId) : base(fileId, fileName, fileSize)
    {
        DurationSeconds = duration;
        TrackName = trackName;
        AlbumName = albumName;
        AuthorName = authorName;
        TrackId = trackId;
        AlbumId = albumId;
        AuthorId = authorId;
    }
}