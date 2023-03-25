using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront.Full;

public class AuthorFull
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List<AlbumLight> Albums { get; set; }
}