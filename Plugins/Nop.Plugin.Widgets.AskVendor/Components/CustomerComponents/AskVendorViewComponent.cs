using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;
using Nop.Web.Models.Common;

namespace Nop.Plugin.Widgets.AskVendor.Components.CustomerComponents
{
    public class AskVendorViewComponent : NopViewComponent
    {
        private readonly IWorkContext _workContext;

        public AskVendorViewComponent(IWorkContext workContext)
        {
            _workContext = workContext;
        }
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            if (additionalData is not ProductDetailsModel)
                return Content("");

            var customer = await _workContext.GetCurrentCustomerAsync();

            var model = (ProductDetailsModel)additionalData;

            if (model.VendorModel.Id == 0 || customer.Email == null)
                return Content("");

            return View("~/Plugins/Widgets.AskVendor/Views/CustomerViews/AskVendor.cshtml", model);
        }
    }
}
