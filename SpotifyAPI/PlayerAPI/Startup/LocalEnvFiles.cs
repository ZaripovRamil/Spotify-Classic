using Utils;

namespace PlayerAPI.Startup;

public static class LocalEnvFiles
{
    public static void Load(string directoryName)
    {
        var files = LocalEnvFileLoader.CombinePaths(directoryName,
            "local.secrets", "local.hostnames", "local.kestrel-conf");
        foreach (var file in files)
        {
            LocalEnvFileLoader.Load(file);
        }
    }
}