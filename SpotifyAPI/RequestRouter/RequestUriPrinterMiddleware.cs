using System.Web;

namespace RequestRouter;

public class RequestUriPrinterMiddleware
{
    private readonly RequestDelegate _next;

    public RequestUriPrinterMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine(context.Request.Path);
        context.Request.Path = new PathString(HttpUtility.UrlEncode(context.Request.Path.ToString()));
        Console.WriteLine(context.Request.Path);
        // Call the next delegate/middleware in the pipeline.
        await _next(context);
    }
}

public static class RequestUriPrinterMiddlewareExtensions
{
    public static IApplicationBuilder UseUriPrinterMiddleware(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<RequestUriPrinterMiddleware>();
    }
}

