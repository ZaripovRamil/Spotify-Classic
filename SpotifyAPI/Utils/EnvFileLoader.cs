using System.Text.RegularExpressions;

namespace Utils;

public static class EnvFileLoader
{
    public static void Load(string filePath)
    {
        if (!File.Exists(filePath))
            return;

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
        const string pattern = @"\$\{(.+?)\}";

        var result = Regex.Replace(input, pattern, match =>
        {
            var variableName = match.Groups[1].Value;

            var variableValue = Environment.GetEnvironmentVariable(variableName) ?? "";

            return variableValue;
        });

        return result;
    }

    public static string[] CombinePaths(string pathPart1, params string[] pathParts2)
    {
        var result = new string[pathParts2.Length];
        for (var i = 0; i < pathParts2.Length; i++)
        {
            result[i] = Path.Combine(pathPart1, pathParts2[i]);
        }

        return result;
    }
}