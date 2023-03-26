using Models;

namespace Database.Services.Accessors.Interfaces;

public interface IDbAlbumAccessor
{
    public Task Add(Album album);
    public Task<Album?> Get(string id);
}