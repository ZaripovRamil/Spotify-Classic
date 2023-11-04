using Utils.LocalRun;

namespace AuthAPI.ConfigurationExtensions;

public static class AddEnvironmentFilesExtension
{
    public static IConfiguration AddEnvironmentFiles(this IConfiguration configuration)
    {
        EnvFileLoader.LoadFilesFromParentDirectory(".postgres-secrets", "local.secrets", Path.Combine("..", "local.hostnames"), "local.kestrel-conf");
        return configuration;
    }
}