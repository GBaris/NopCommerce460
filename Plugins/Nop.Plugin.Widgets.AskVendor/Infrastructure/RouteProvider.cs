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

            endpointRouteBuilder.MapControllerRoute("WidgetsAskVendorQuestions",
                "Admin/Vendor/Questions",
                new { controller = "Vendor", action = "Questions", area = "Admin" });
        }

        public int Priority => 1;
    }
}
