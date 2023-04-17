using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;
using Nop.Web.Models.Common;

namespace Nop.Plugin.Widgets.AskVendor.Components.CustomerComponents
{
    public class CustomerHasMessageComponent : NopViewComponent
    {
        private readonly IWorkContext _workContext;

        public CustomerHasMessageComponent(IWorkContext workContext)
        {
            _workContext = workContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            if (additionalData is not HeaderLinksModel)
                return Content("");

            var customer = await _workContext.GetCurrentCustomerAsync();

            var model = (HeaderLinksModel)additionalData;

            if (customer == null)
                return Content("");

            return View("~/Plugins/Widgets.AskVendor/Views/CustomerViews/CustomerHasMessageButton.cshtml", model);
        }
    }
}
