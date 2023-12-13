namespace Models.Metadata;

public class ImageMetadata : Metadata
{
    public int Height { get; set; }
    public int Width { get; set; }

    public ImageMetadata() { }

    public ImageMetadata(string fileId, string fileName, long fileSize, int height, int width) : base(fileId,fileName,fileSize)
    {
        Height = height;
        Width = width;
    }
}