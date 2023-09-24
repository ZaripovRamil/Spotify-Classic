namespace Models;

public class ApplicationHosts
{
    public string StaticApi { get; set; } = default!;
    public string DatabaseApi { get; set; } = default!;
    public string AdminApi { get; set; } = default!;
    public string PlayerApi { get; set; } = default!;
    public string AuthApi { get; set; } = default!;
    public string SearchApi { get; set; } = default!;
    public string UsersFrontend { get; set; } = default!;
    public string AdminFrontend { get; set; } = default!;
}