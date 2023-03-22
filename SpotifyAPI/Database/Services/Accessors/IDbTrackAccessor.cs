using Microsoft.AspNetCore.Mvc;
using Models;

namespace Database.Services.Accessors;

public interface IDbTrackAccessor
{
    public Task Add(Track track);
    public Task<Track?> Get(string id);
    public IEnumerable<Track> GetAll();
}