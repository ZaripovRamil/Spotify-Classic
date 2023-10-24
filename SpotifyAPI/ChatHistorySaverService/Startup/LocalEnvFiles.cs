using Utils;

namespace ChatHistorySaverService.Startup;

public static class LocalEnvFiles
{
    public static void Load(string directoryName)
    {
        var files = LocalEnvFileLoader.CombinePaths(directoryName,
            ".rabbitmq-secrets", "local.secrets", "local.hostnames");
        foreach (var file in files)
        {
            LocalEnvFileLoader.Load(file);
        }
    }
}