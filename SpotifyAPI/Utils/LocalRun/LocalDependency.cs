using System.Diagnostics;

namespace Utils.LocalRun;

public abstract class LocalDependency<TConfig> where TConfig : class
{
    public abstract bool Start(TConfig config);
    
    public abstract bool Exit();

    protected static bool IsDockerContainerRunning(string containerName)
    {
        var process = StartProcess("docker", "ps", true);
        var content = process.StandardOutput.ReadToEnd();
        process.WaitForExit();
        return content.Contains(containerName);
    }

    private static Process StartProcess(string command, string arguments, bool redirectStdout = false)
    {
        var process = new Process();

        process.StartInfo.FileName = command;
        process.StartInfo.Arguments = arguments;
        process.StartInfo.RedirectStandardOutput = redirectStdout;

        process.Start();
        return process;
    }
    
    protected static bool RunProcess(string command, string arguments)
    {
        try
        {
            using var process = StartProcess(command, arguments);
            
            process.WaitForExit();
            var isSuccessful = process.ExitCode == 0;
            process.Close();
            return isSuccessful;
        }
        catch (Exception)
        {
            return false;
        }
    }
}