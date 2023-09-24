namespace Models.DTO.FrontToBack.EntityCreationData;

public class TrackCreationData : EntityCreationData
{
    public string AlbumId { get; set; } = default!;
    public string[] GenreIds { get; set; } = Array.Empty<string>();
}