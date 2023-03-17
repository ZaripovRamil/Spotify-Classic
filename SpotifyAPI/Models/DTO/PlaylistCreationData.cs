namespace Models.DTO;

public class PlaylistCreationData
{
    public string Name { get; set; }
    public string OwnerId { get; set; }
    public PlaylistType Type { get; set; }
}