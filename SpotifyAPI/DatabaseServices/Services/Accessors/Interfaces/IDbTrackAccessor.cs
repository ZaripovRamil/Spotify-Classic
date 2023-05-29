using Models.Entities;

namespace DatabaseServices.Services.Accessors.Interfaces;

public interface IDbTrackAccessor
{
    public Task Add(Track track);
    public Task<Track?> Get(string id);
    public IQueryable<Track> GetAll();
    public Task Delete(Track track);
    public Task Update(Track track);
}