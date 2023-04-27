using System.Net.Http.Json;
using System.Reflection;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace APIServices;

public static class RouteOverseer
{
    private const string RouterUri = "https://localhost:7121/AddRoutes";
    private static HttpClient Client { get; set; } = new();

    public static async void SendAssemblyRoutes(string baseUrl, Assembly assembly)
    {
        var controllers = assembly.GetTypes()
            .Where(t => t.GetCustomAttributes<ApiControllerAttribute>().FirstOrDefault() != null);
        var routingInfo = new AssemblyRoutingInfo(baseUrl, controllers
            .Select(GetControllerRoutes).ToArray());
        Console.WriteLine(JsonSerializer.Serialize(routingInfo));
        await PostToRouter(routingInfo);
    }

    private static async Task PostToRouter(AssemblyRoutingInfo routingInfo)
    {
        var message = new HttpRequestMessage();
        message.Method = HttpMethod.Post;
        message.Content = JsonContent.Create(routingInfo);
        message.RequestUri = new Uri(RouterUri);
        await Client.SendAsync(message);
    }

    private static ControllerRoutingInfo GetControllerRoutes(Type controller)
    {
        var controllerUrl = controller.GetCustomAttributes<RouteAttribute>().FirstOrDefault()?.Template??"";
        var methods = controller.GetMethods()
            .Where(m =>
                m.GetCustomAttributes<HttpGetAttribute>().FirstOrDefault() != null ||
                m.GetCustomAttributes<HttpPostAttribute>().FirstOrDefault() != null ||
                m.GetCustomAttributes<HttpPutAttribute>().FirstOrDefault() != null ||
                m.GetCustomAttributes<HttpDeleteAttribute>().FirstOrDefault() != null);
        return new ControllerRoutingInfo(controllerUrl, methods
            .Select(GetMethodRoute).ToArray());
    }

    private static RouteInfo GetMethodRoute(MethodInfo arg)
    {
        return new RouteInfo(arg.GetCustomAttributes<RouteAttribute>().FirstOrDefault()?.Template ?? "");
    }
}