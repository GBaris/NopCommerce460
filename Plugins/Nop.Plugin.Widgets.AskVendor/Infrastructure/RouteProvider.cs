using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Nop.Web.Framework.Mvc.Routing;

namespace Nop.Plugin.Widgets.AskVendor.Infrastructure
{
    public class RouteProvider : IRouteProvider
    {
        public void RegisterRoutes(IEndpointRouteBuilder endpointRouteBuilder)
        {
            endpointRouteBuilder.MapControllerRoute("WidgetsAskVendorAskQuestion",
                "AskQuestion",
                new { controller = "AskVendor", action = "AskQuestion" });
        }

        public int Priority => 1;
    }
}