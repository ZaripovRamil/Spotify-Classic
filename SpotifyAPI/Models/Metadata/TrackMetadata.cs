namespace Models.Metadata;

public class TrackMetadata : Metadata
{
    public uint DurationSeconds { get; set; }
    public string TrackName { get; set; }
    public string AlbumName { get; set; }
    public string AuthorName { get; set; }
    public string TrackId { get; set; }
    public string AlbumId { get; set; }
    public string AuthorId { get; set; }

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