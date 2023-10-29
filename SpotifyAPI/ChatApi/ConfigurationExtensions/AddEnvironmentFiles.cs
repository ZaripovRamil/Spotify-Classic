using Utils.LocalRun;

namespace ChatApi.ConfigurationExtensions;

public static class AddEnvironmentFilesExtension
{
    public static IConfiguration AddEnvironmentFiles(this IConfiguration configuration)
    {
        EnvFileLoader.LoadFilesFromParentDirectory(".rabbitmq-secrets", ".postgres-secrets", "local.secrets", Path.Combine("..", "local.hostnames"), "local.kestrel-conf");
        return configuration;
    }
}