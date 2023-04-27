namespace APIServices;

public class ControllerRoutingInfo
{
    public ControllerRoutingInfo(string controllerUri, RouteInfo[] routes)
    {
        ControllerUri = controllerUri;
        Routes = routes;
    }

    public string ControllerUri { get; set; }
    public RouteInfo[]Routes { get; set; }
}