namespace Models.Configuration;

public class Hosts
{
    public required string StaticApi { get; set; }
    public required string AdminApi { get; set; }
    public required string PlayerApi { get; set; }
    public required string AuthApi { get; set; }
    public required string SearchApi { get; set; }
    public required string ChatApi { get; set; }
    public required string ChatHistorySaverService { get; set; }
    public required string UserApi { get; set; }
    public required string UsersFrontend { get; set; }
    public required string AdminFrontend { get; set; }
}