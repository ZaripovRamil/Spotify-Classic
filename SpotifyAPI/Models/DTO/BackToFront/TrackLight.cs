namespace Models.DTO.BackToFront;

public class TrackLight
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string PreviewId { get; set; }
    public AuthorLight Author { get; set; }
    public AlbumLight Album { get; set; }
}