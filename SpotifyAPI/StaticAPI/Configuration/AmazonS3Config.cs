namespace StaticAPI.Configuration;

public class AmazonS3Config
{
    public required string AccessKey { get; set; }
    public required string SecretKey { get; set; }
    public required string AuthenticationRegion { get; set; }
    public required string ServiceUrl { get; set; }
    public required bool ForcePathStyle { get; set; }
}