using Models.DTO.BackToFront;

namespace SearchAPI.Services;

public interface ISearchEngine
{
    public Task<SearchResult> SearchAsync(string query);
}