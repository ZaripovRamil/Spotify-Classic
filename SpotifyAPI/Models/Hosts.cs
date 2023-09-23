namespace Models;

public class Hosts
{
    public required string StaticApi { get; set; }
    public required string DatabaseApi { get; set; }
    public required string AdminApi { get; set; }
    public required string PlayerApi { get; set; }
    public required string AuthApi { get; set; }
    public required string SearchApi { get; set; }
    public required string ChatApi { get; set; }
    public required string UsersFrontend { get; set; }
    public required string AdminFrontend { get; set; }
}