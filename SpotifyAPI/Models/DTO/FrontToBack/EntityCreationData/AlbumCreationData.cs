using Models.Entities.Enums;

namespace Models.DTO.FrontToBack.EntityCreationData;

public class AlbumCreationData
{
    public string Name { get; set; }
    public string AuthorId { get; set; }
    public AlbumType AlbumType { get; set; }
    public int ReleaseDate { get; set; }
}