using Models.DTO.BackToFront.Light;

namespace Models.DTO.BackToFront;

public class AlbumsSearchResult
{
    public AlbumsSearchResult(List<AlbumLight> albums)
    {
        Albums = albums;
    }
    
    public List<AlbumLight> Albums { get; set; }
}