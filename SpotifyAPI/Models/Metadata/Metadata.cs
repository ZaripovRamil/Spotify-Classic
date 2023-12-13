namespace Models.Metadata;

public class Metadata
{
    public string FileId { get; set; }
    public string FileName { get; set; }
    public long FileSize { get; set; }

    public Metadata() { }
    public Metadata(string fileId, string fileName, long fileSize)
    {
        FileId = fileId;
        FileName = fileName;
        FileSize = fileSize;
    }
}