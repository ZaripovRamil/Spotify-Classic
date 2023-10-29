using Utils.LocalRun;

namespace ChatHistorySaverService.ConfigurationExtensions;

public static class AddEnvironmentFilesExtension
{
    public static IConfiguration AddEnvironmentFiles(this IConfiguration configuration)
    {
        EnvFileLoader.LoadFilesFromParentDirectory(".rabbitmq-secrets", ".postgres-secrets", "local.secrets", Path.Combine("..", "local.hostnames"));
        return configuration;
    }
}