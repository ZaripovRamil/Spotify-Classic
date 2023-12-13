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
}