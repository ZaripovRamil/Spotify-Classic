using Models.DTO.BackToFront;
using Models.Entities;

namespace SearchAPI.Services;

public interface ISearchEngine
{
    public Task<SearchResult> SearchAsync(string query);
}