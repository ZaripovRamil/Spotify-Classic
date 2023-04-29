using DatabaseServices.Services.Accessors.Interfaces;
using Models.Entities;
using Nest;

namespace SearchAPI.Services;

public class SearchEngine:ISearchEngine
{
    private static async Task<ElasticClient> CreateElasticClient()
    {
        var settings = new ConnectionSettings(new Uri("http://localhost:9200"))
            .DefaultMappingFor<Entity>(m => m
                .Ignore(p => p.Id)
                .Ignore(p => p.Name))
            .DefaultMappingFor<Track>(m=>m.IndexName("Tracks"))
            .DefaultMappingFor<Album>(m=>m.IndexName("Albums"))
            .DefaultMappingFor<Author>(m=>m.IndexName("Authors"))
            .DefaultMappingFor<Playlist>(m=>m.IndexName("Playlists"));
        var client = new ElasticClient(settings);
        await DeleteIndices(client);
        await IndexData(client);
        return client;
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
        foreach (var track in tracks)
            await client.IndexAsync(track, i => i.Index("Tracks"));
        foreach (var album in albums)
            await client.IndexAsync(album, i => i.Index("Albums"));
        foreach (var author in authors)
            await client.IndexAsync(author, i=>i.Index("Authors"));
        foreach (var playlist in playlists)
            await client.IndexAsync(playlist, i => i.Index("Playlists"));
    }
    
    private static async Task DeleteIndices(ElasticClient client)
    {
        var indices = new List<string> { "Tracks", "Albums", "Authors", "Playlists" };
    
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
    public async Task<List<Track>> SearchAsync(string query)
    {
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

        return searchResponse.Documents.ToList();
    }
}