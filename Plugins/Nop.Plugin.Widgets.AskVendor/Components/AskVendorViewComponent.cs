using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Data.Mapping.Builders.Orders;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;

namespace Nop.Plugin.Widgets.AskVendor.Components
{
    public class AskVendorViewComponent : NopViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            if(additionalData is not ProductDetailsModel)
            {
                return Content("");
            }
            var model = (ProductDetailsModel)additionalData;

            if(model.VendorModel.Id == 0)
            {
                return Content("");
            }
            return await Task.FromResult(View("~/Plugins/Widgets.AskVendor/Views/AskVendor.cshtml"));
        }
    }
}
