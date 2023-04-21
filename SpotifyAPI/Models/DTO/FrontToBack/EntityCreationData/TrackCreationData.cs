namespace Models.DTO.FrontToBack.EntityCreationData;

public class TrackCreationData : EntityCreationData
{
    public string AlbumId { get; set; }
    public string[] GenreIds { get; set; }
}