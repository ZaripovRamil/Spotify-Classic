using Microsoft.Extensions.Options;
using Models.Metadata;
using MongoDB.Driver;
using StaticAPI.Configuration;

namespace StaticAPI.Services;

public class ImageMetadataRepository: IRepository<ImageMetadata>
{
    private readonly IMongoCollection<ImageMetadata> _imageMetadataCollection;
    
    public ImageMetadataRepository(IOptions<MongoConfig> config, IMongoDatabase database)
    {
        _imageMetadataCollection = database.GetCollection<ImageMetadata>(config.Value.ImagesMetadataCollectionName);
    }

    public async Task<IEnumerable<ImageMetadata>> GetAllAsync()
    {
        return await _imageMetadataCollection.Find(_ => true).ToListAsync();
    }

    public async Task<ImageMetadata?> GetByIdAsync(string id)
    {
        return await _imageMetadataCollection.Find(_ => _.FileId == id).FirstOrDefaultAsync();
    }

    public async Task CreateAsync(ImageMetadata newItem)
    {
        await _imageMetadataCollection.InsertOneAsync(newItem);
    }

    public async Task UpdateAsync(ImageMetadata itemToUpdate)
    {
        await _imageMetadataCollection.ReplaceOneAsync(x => x.FileId == itemToUpdate.FileId, itemToUpdate);
    }

    public async Task DeleteAsync(string id)
    {
        await _imageMetadataCollection.DeleteOneAsync(x => x.FileId == id);
    }
}