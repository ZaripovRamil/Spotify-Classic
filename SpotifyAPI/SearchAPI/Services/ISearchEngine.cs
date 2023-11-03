using Models.DTO.BackToFront;
using Models.DTO.BackToFront.Full;
using SearchAPI.Features.SearchUsers;

namespace SearchAPI.Services;

public interface ISearchEngine
{
    public Task<SearchResult> SearchAsync(string query);
    public Task<ResultDto> SearchUsersAsync(string query);
    public Task<AlbumsSearchResult> SearchAlbumsAsync(string query);
    public Task<IEnumerable<AlbumFull>> SearchAlbumsByAuthorsAsync(string query);
    public Task<IEnumerable<AuthorFull>> SearchAuthorsByUserAsync(string query);
    public Task<IEnumerable<TrackFull>> SearchTracksByAlbumOrAuthorAsync(string query);
}