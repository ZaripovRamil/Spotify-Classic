namespace Models.Metadata;

public class Metadata
{
    public string FileId { get; set; } = default!;
    public string FileName { get; set; } = default!;
    public long FileSize { get; set; }

    public Metadata() { }
    public Metadata(string fileId, string fileName, long fileSize)
    {
        FileId = fileId;
        FileName = fileName;
        FileSize = fileSize;
    }
}