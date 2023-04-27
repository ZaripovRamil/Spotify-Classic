using System.Net;
using System.Web;
using APIServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;

namespace RequestRouter.Controllers;

[ApiController]
public class GatewayController : Controller
{
    private static HttpClient _client = new();
    private Dictionary<string, string> BaseUrls { get; set; } = new();

    [HttpPost]
    [Route("{url}")]
    public async Task HandlePostRequest(string url)
    {
        await Invoke(HttpContext);
    }

    [HttpPost]
    [Route("AddRoutes")]
    public IActionResult AddRoutes([FromBody] AssemblyRoutingInfo assemblyRoutingInfo)
    {
        var baseUrl = assemblyRoutingInfo.BaseUri;
        var allRoutes = assemblyRoutingInfo.ControllerRoutes
            .SelectMany(c => c.Routes
                .Select(r => c.ControllerUri + "/" + r.Route));
        foreach (var route in allRoutes)
        {
            BaseUrls[route] = baseUrl;
            Console.WriteLine(baseUrl + "/" + route);
        }

        return Ok();
    }

    [HttpGet]
    [Route("{url:regex((.*?))}")]
    public async Task HandleGetRequest(string url)
    {
        await Invoke(HttpContext);
    }

    private async Task Invoke(HttpContext context)
    {
        var targetUri = BuildTargetUri(context.Request);

        if (targetUri != null)
        {
            var targetRequestMessage = CreateTargetMessage(context, targetUri);

            using (var responseMessage = await _client.SendAsync(targetRequestMessage,
                       HttpCompletionOption.ResponseHeadersRead, context.RequestAborted))
            {
                context.Response.StatusCode = (int) responseMessage.StatusCode;
                CopyFromTargetResponseHeaders(context, responseMessage);
                await responseMessage.Content.CopyToAsync(context.Response.Body);
            }
        }
    }

    private HttpRequestMessage CreateTargetMessage(HttpContext context, Uri targetUri)
    {
        var requestMessage = new HttpRequestMessage();
        CopyFromOriginalRequestContentAndHeaders(context, requestMessage);

        requestMessage.RequestUri = targetUri;
        requestMessage.Headers.Host = targetUri.Host;
        requestMessage.Method = GetMethod(context.Request.Method);

        return requestMessage;
    }

    private void CopyFromOriginalRequestContentAndHeaders(HttpContext context, HttpRequestMessage requestMessage)
    {
        var requestMethod = context.Request.Method;

        if (!HttpMethods.IsGet(requestMethod) &&
            !HttpMethods.IsHead(requestMethod) &&
            !HttpMethods.IsDelete(requestMethod) &&
            !HttpMethods.IsTrace(requestMethod))
        {
            var streamContent = new StreamContent(context.Request.Body);
            requestMessage.Content = streamContent;
        }

        foreach (var header in context.Request.Headers)
        {
            requestMessage.Content?.Headers.TryAddWithoutValidation(header.Key, header.Value.ToArray());
        }
    }

    private void CopyFromTargetResponseHeaders(HttpContext context, HttpResponseMessage responseMessage)
    {
        foreach (var header in responseMessage.Headers)
        {
            context.Response.Headers[header.Key] = header.Value.ToArray();
        }

        foreach (var header in responseMessage.Content.Headers)
        {
            context.Response.Headers[header.Key] = header.Value.ToArray();
        }

        context.Response.Headers.Remove("transfer-encoding");
    }

    private static HttpMethod GetMethod(string method)
    {
        if (HttpMethods.IsDelete(method)) return HttpMethod.Delete;
        if (HttpMethods.IsGet(method)) return HttpMethod.Get;
        if (HttpMethods.IsHead(method)) return HttpMethod.Head;
        if (HttpMethods.IsOptions(method)) return HttpMethod.Options;
        if (HttpMethods.IsPost(method)) return HttpMethod.Post;
        if (HttpMethods.IsPut(method)) return HttpMethod.Put;
        if (HttpMethods.IsTrace(method)) return HttpMethod.Trace;
        return new HttpMethod(method);
    }

    private Uri BuildTargetUri(HttpRequest request)
    {
        Uri targetUri = null;
        var truePath = HttpUtility.HtmlDecode(request.Path.Value);
        Console.WriteLine("Building target path: "+ truePath);
        var uri = string.Join('/', truePath.Split("/").Skip(3));
        if (BaseUrls.ContainsKey(uri))
            targetUri = new Uri(BaseUrls[uri] + uri);
        return targetUri;
    }
    
}