namespace Utils.LocalRun;

public static class ApplicationEnvironment
{
    public static bool IsContainer =>
        bool.Parse(Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") ?? "false");
}