using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;
using Nop.Web.Models.Common;

namespace Nop.Plugin.Widgets.AskVendor.Components.VendorComponents
{
    public class VendorHasMessageComponent : NopViewComponent
    {
        private readonly IWorkContext _workContext;

        public VendorHasMessageComponent(IWorkContext workContext)
        {
            _workContext = workContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            if (additionalData is not HeaderLinksModel)
                return Content("");

            var vendor = await _workContext.GetCurrentVendorAsync();

            var model = (HeaderLinksModel)additionalData;

            if (vendor == null)
                return Content("");

            return View("~/Plugins/Widgets.AskVendor/Views/VendorViews/VendorHasMessageButton.cshtml", model);
        }
    }
}
