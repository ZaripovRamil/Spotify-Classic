namespace Models.DTO.FrontToBack.EntityCreationData;

public class TrackCreationData
{
    public string Name { get; set; }
    public string AlbumId { get; set; }
    public List<string> GenreIds { get; set; }
}