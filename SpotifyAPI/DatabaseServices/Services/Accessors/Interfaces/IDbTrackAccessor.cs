using Models.Entities;

namespace Database.Services.Accessors.Interfaces;

public interface IDbTrackAccessor
{
    public Task Add(Track track);
    public Task<Track?> Get(string id);
    public IEnumerable<Track> GetAll();
}