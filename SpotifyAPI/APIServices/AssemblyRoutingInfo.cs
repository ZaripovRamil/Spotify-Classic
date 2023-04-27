namespace APIServices;

public class AssemblyRoutingInfo
{
    public AssemblyRoutingInfo(string baseUri, ControllerRoutingInfo[] controllerRoutes)
    {
        BaseUri = baseUri;
        ControllerRoutes = controllerRoutes;
    }

    public string BaseUri { get; set; }
    public ControllerRoutingInfo[] ControllerRoutes { get; set; }
}