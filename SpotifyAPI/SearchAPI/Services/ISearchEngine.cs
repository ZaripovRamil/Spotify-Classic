using Models.DTO.BackToFront;

namespace SearchAPI.Services;

public interface ISearchEngine
{
    public Task<SearchResult> SearchAsync(string query);
    public Task<UsersSearchResult> SearchUsersAsync(string query);
    public Task<AlbumsSearchResult> SearchAlbumsAsync(string query);
}