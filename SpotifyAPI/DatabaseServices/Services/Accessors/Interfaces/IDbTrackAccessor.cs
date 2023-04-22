using Models.Entities;

namespace DatabaseServices.Services.Accessors.Interfaces;

public interface IDbTrackAccessor
{
    public Task Add(Track track);
    public Task<Track?> Get(string id);
    public IEnumerable<Track> GetAll();
    public Task Delete(Track track);
}