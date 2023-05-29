using DatabaseServices.Services.Accessors.Interfaces;
using Models.DTO.BackToFront;
using Models.Entities;
using Nest;

namespace SearchAPI.Services;

public class SearchEngine:ISearchEngine
{
    private static async Task<ElasticClient> CreateElasticClient()
    {
        var settings = new ConnectionSettings(new Uri("https://localhost:9200"))
            .DisableDirectStreaming()
            .BasicAuthentication("elastic", "changeme")
            .DefaultMappingFor<Track>(m=>m.IndexName("tracks"))
            .DefaultMappingFor<Album>(m=>m.IndexName("albums"))
            .DefaultMappingFor<Author>(m=>m.IndexName("authors"))
            .DefaultMappingFor<Playlist>(m=>m.IndexName("playlists"));
        settings.EnableApiVersioningHeader();    
        var client = new ElasticClient(settings);
        await DeleteIndices(client);
        await IndexData(client);
        return client;
    }
    
    private static IIndexState CustomIndexSettings()
    {
        return new IndexState
        {
            Settings = new IndexSettings
            {
                { "index.analysis.analyzer.default.type", "simple" }
            },
            Mappings = new TypeMappingDescriptor<Entity>()
                .Properties(props => props
                    .Text(t => t.Name("Name").Analyzer("simple"))
                )
        };
    }
    
    private static IDbTrackAccessor _trackAccessor;
    private static IDbAlbumAccessor _albumAccessor;
    private static IDbAuthorAccessor _authorAccessor;
    private static IDbPlaylistAccessor _playlistAccessor;
    private static ElasticClient? ElasticClient;

    public SearchEngine(IDbTrackAccessor trackAccessor, IDbAlbumAccessor albumAccessor, IDbAuthorAccessor authorAccessor, IDbPlaylistAccessor playlistAccessor)
    {
        _trackAccessor = trackAccessor;
        _albumAccessor = albumAccessor;
        _authorAccessor = authorAccessor;
        _playlistAccessor = playlistAccessor;
        if(ElasticClient == null)
            ElasticClient = CreateElasticClient().GetAwaiter().GetResult();
    }

    private static async Task IndexData(ElasticClient client)
    {
        var tracks = _trackAccessor.GetAll();
        var albums = _albumAccessor.GetAll();
        var playlists = _playlistAccessor.GetAll();
        var authors = _authorAccessor.GetAll();

        var indexSettings = CustomIndexSettings();

        await client.Indices.CreateAsync("tracks", c => c.InitializeUsing(indexSettings));
        await client.Indices.CreateAsync("albums", c => c.InitializeUsing(indexSettings));
        await client.Indices.CreateAsync("authors", c => c.InitializeUsing(indexSettings));
        await client.Indices.CreateAsync("playlists", c => c.InitializeUsing(indexSettings));

        await client.IndexManyAsync(tracks, "tracks");
        await client.IndexManyAsync(albums, "albums");
        await client.IndexManyAsync(authors, "authors");
        await client.IndexManyAsync(playlists, "playlists");
    }

    
    private static async Task DeleteIndices(ElasticClient client)
    {
        var indices = new List<string> { "tracks", "albums", "authors", "playlists" };
    
        foreach (var index in indices)
        {
            if ((await client.Indices.ExistsAsync(index)).Exists)
            {
                var deleteIndexResponse = await client.Indices.DeleteAsync(index);
                if (!deleteIndexResponse.IsValid)
                {
                    throw new Exception($"Failed to delete index {index}: {deleteIndexResponse.ServerError.Error.Reason}");
                }
            }
        }
    }
    public async Task<SearchResult> SearchAsync(string query)
    {
        throw new NotImplementedException();
        var client = ElasticClient;

        var searchResponse = await client.SearchAsync<Track>(s => s
            .AllIndices()
            .Query(q => q
                .MultiMatch(mm => mm
                    .Fields(f => f
                        .Field("Name"))
                    .Query(query)
                    .Analyzer("simple")
                )
            )
        );

        Console.WriteLine(!searchResponse.IsValid
            ? $"Search error: {searchResponse.DebugInformation}"
            : $"Search successful: {searchResponse.DebugInformation}");
        return null; //Enumerable.Empty<Entity>().Concat(searchResponse.Documents).ToList();
    }

    public Task<UsersSearchResult> SearchUsersAsync(string query)
    {
        throw new NotImplementedException();
    }

    public Task<AlbumsSearchResult> SearchAlbumsAsync(string query)
    {
        throw new NotImplementedException();
    }
}