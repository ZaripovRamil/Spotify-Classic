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
}