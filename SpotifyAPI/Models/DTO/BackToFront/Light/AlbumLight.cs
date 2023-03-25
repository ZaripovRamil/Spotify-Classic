namespace Models.DTO.BackToFront.Light;

public class AlbumLight//TODO: Join with playlistLight?
{
    public string Id { get; set; }
    public string Name { get; set; }
    
    public UserLight Author { get; set; }

    public AlbumLight(Playlist album)
    {
        Id = album.Id;
        Name = album.Name;
        Author = new UserLight(album.Owner);
    }
}