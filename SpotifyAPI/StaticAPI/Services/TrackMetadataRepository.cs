using Microsoft.Extensions.Options;
using Models.Metadata;
using MongoDB.Driver;
using StaticAPI.Configuration;

namespace StaticAPI.Services;

public class TrackMetadataRepository: IRepository<TrackMetadata>
{
    private readonly IMongoCollection<TrackMetadata> _trackMetadataCollection;
    
    public TrackMetadataRepository(IOptions<MongoConfig> config, IMongoDatabase database)
    {
        _trackMetadataCollection = database.GetCollection<TrackMetadata>(config.Value.TracksMetadataCollectionName);
    }
    public async Task<IEnumerable<TrackMetadata>> GetAllAsync()
    {
        return await _trackMetadataCollection.Find(_ => true).ToListAsync();
    }

    public async Task<TrackMetadata?> GetByIdAsync(string id)
    {
        return await _trackMetadataCollection.Find(_ => _.FileId == id).FirstOrDefaultAsync();
    }

    public async Task CreateAsync(TrackMetadata newItem)
    {
        await _trackMetadataCollection.InsertOneAsync(newItem);
    }

    public async Task UpdateAsync(TrackMetadata itemToUpdate)
    {
        await _trackMetadataCollection.ReplaceOneAsync(x => x.FileId == itemToUpdate.FileId, itemToUpdate);
    }

    public async Task DeleteAsync(string id)
    {
        await _trackMetadataCollection.DeleteOneAsync(x => x.FileId == id);
    }
}