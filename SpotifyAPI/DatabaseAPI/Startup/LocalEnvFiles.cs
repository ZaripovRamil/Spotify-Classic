using Utils;

namespace DatabaseAPI.Startup;

public static class LocalEnvFiles
{
    public static void Load(string directoryName)
    {
        var files = LocalEnvFileLoader.CombinePaths(directoryName,
            ".postgres-secrets", "local.secrets", "local.hostnames", "local.kestrel-conf");
        foreach (var file in files)
        {
            LocalEnvFileLoader.Load(file);
        }
    }
}