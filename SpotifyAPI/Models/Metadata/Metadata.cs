using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.Metadata;

public class Metadata
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string FileId { get; set; } = default!;
    public string FileName { get; set; } = default!;
    public long FileSize { get; set; }
}