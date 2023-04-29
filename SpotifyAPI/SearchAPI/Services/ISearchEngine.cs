using Models.Entities;

namespace SearchAPI.Services;

public interface ISearchEngine
{
    public Task<List<Track>> SearchAsync(string query);
}