using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Metadata;

public class Metadata
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string FileId { get; set; }
    public string FileName { get; set; }
    public long FileSize { get; set; }
}