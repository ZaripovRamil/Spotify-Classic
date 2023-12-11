namespace Models.DTO;

public class FileDataDto
{
    public IFormFile File { get; set; }

    public Metadata.Metadata Data { get; set; }
}