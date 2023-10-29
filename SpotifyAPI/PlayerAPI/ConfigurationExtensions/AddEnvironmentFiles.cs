using Utils.LocalRun;

namespace PlayerAPI.ConfigurationExtensions;

public static class AddEnvironmentFilesExtension
{
    public static IConfiguration AddEnvironmentFiles(this IConfiguration configuration)
    {
        EnvFileLoader.LoadFilesFromParentDirectory("local.secrets", Path.Combine("..", "local.hostnames"), "local.kestrel-conf");
        return configuration;
    }
}