namespace StaticAPI.Configuration;

public class MongoConfig
{
    public required string ConnectionString { get; set; }
    public required string DatabaseName { get; set; }
    public required string ImagesMetadataCollectionName { get; set; }
    public required string TracksMetadataCollectionName { get; set; }
}