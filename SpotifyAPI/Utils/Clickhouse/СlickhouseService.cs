using ClickHouse.Client.ADO;
using Models.Entities;

namespace Utils.Clickhouse;

public interface IClickHouseService
{
    public Task CreateListenTableAsync();
    public Task InsertListenAsync(TrackListen listen);
    public Task<int> GetTrackListenCount(string trackId);
}

public class ClickHouseService : IClickHouseService
{
    private readonly ClickHouseConnection _connection;
    private const string TableName = "AlbumListens";

    public ClickHouseService(string connectionString)
    {
        _connection = new ClickHouseConnection(connectionString);
    }

    public async Task CreateListenTableAsync()
    {
        await _connection.OpenAsync();
        var command = _connection.CreateCommand();
        command.CommandText =
            $"CREATE TABLE IF NOT EXISTS {TableName} (trackId String, listenCount Int32) ENGINE = MergeTree() ORDER BY (trackId)";
        await command.ExecuteNonQueryAsync();
        await _connection.CloseAsync();
    }

    public async Task InsertListenAsync(TrackListen listen)
    {
        await _connection.OpenAsync();
        var command = _connection.CreateCommand();
        command.CommandText =
            $"INSERT INTO {TableName} (trackId, listenCount) VALUES ('{listen.TrackId}', {listen.ListenCount})";

        await command.ExecuteNonQueryAsync();
        await _connection.CloseAsync();
    }

    public async Task<int> GetTrackListenCount(string trackId)
    {
        await _connection.OpenAsync();
        var command = _connection.CreateCommand();
        command.CommandText = $"SELECT * FROM {TableName} WHERE trackId = '{trackId}'";
        var reader = await command.ExecuteReaderAsync();
        var result = 0;
        while (await reader.ReadAsync())
        {
            result += reader.GetFieldValue<int>(1);
        }

        await _connection.CloseAsync();
        return result;
    }
}