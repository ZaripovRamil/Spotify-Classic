using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace Utils.LocalRun;

public static class LocalDependencies
{
    private static readonly IEnumerable<Type> LocalDependenciesTypes = typeof(LocalDependencies).Assembly.GetTypes()
        .Where(t => t.IsClass &&
                    t is { IsAbstract: false, BaseType.IsGenericType: true } &&
                    t.BaseType.GetGenericTypeDefinition() == typeof(LocalDependency<>));

    public static void EnsureStarted(IConfiguration configuration)
    {
        foreach (var dep in LocalDependenciesTypes)
        {
            var configParameter = dep.BaseType!.GetGenericArguments()[0];
            var configInstance = configParameter.GetConstructor(Array.Empty<Type>())!.Invoke(null);
            foreach (var configPropertyInfo in configParameter.GetProperties())
                configPropertyInfo.SetValue(configInstance,
                    configuration[$"{configParameter.Name}:{configPropertyInfo.Name}"]);

            GetMethod(dep, nameof(LocalDependency<object>.Start))(new[] { configInstance });
        }
    }

    public static void EnsureExited()
    {
        foreach (var dep in LocalDependenciesTypes)
        {
            GetMethod(dep, nameof(LocalDependency<object>.Exit))(Array.Empty<object>());
        }
    }

    private static Func<object?[], object?> GetMethod(Type type, string methodName)
    {
        var instance = type.GetConstructor(Array.Empty<Type>())!.Invoke(null);
        var method = type.GetMethod(methodName,
            BindingFlags.Instance | BindingFlags.Public)!;
        return objects => method.Invoke(instance, objects);
    }
}