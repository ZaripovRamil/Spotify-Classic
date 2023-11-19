using Utils.LocalRun;

namespace StaticAPI.ConfigurationExtensions;

public static class AddEnvironmentFilesExtension
{
    public static IConfiguration AddEnvironmentFiles(this IConfiguration configuration)
    {
        EnvFileLoader.LoadFilesFromParentDirectory(".minio-secrets", "local.secrets",
            Path.Combine("..", "local.hostnames"), "local.kestrel-conf");
        return configuration;
    }
}