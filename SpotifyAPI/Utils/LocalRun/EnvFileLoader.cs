using System.Text.RegularExpressions;

namespace Utils.LocalRun;

public static partial class EnvFileLoader
{
    public static void LoadFilesFromParentDirectory(params string[] filePaths)
    {
        var files = CombinePaths(Directory.GetParent(Directory.GetCurrentDirectory())!.FullName, filePaths);
        foreach (var file in files) Load(file);
    }

    public static void Load(string filePath)
    {
        if (ApplicationEnvironment.IsContainer)
            return;
        if (!File.Exists(filePath))
            throw new FileNotFoundException(filePath);

        foreach (var line in File.ReadAllLines(filePath))
        {
            var eqSign = line.IndexOf('=');
            if (eqSign == -1) continue;
            var part1 = line[..eqSign];
            var part2 = line[(eqSign + 1)..];
            part2 = SubstituteEnvironmentVariables(part2);
            
            Environment.SetEnvironmentVariable(part1, part2);
        }
    }
    
    private static string SubstituteEnvironmentVariables(string input)
    {
        var result = EnvironmentVariableSubstRegex().Replace(input, match =>
        {
            var variableName = match.Groups[1].Value;

            var variableValue = Environment.GetEnvironmentVariable(variableName) ?? "";

            return variableValue;
        });

        return result;
    }

    private static IEnumerable<string> CombinePaths(string pathPart1, params string[] pathParts2)
    {
        var result = new string[pathParts2.Length];
        for (var i = 0; i < pathParts2.Length; i++)
        {
            result[i] = Path.Combine(pathPart1, pathParts2[i]);
        }

        return result;
    }

    // finds ${} entries
    [GeneratedRegex(@"\$\{(.+?)\}", default, 500)]
    private static partial Regex EnvironmentVariableSubstRegex();
}