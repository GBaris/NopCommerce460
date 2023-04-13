using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Plugin.Widgets.AskVendor.Components;
using Nop.Services.Cms;
using Nop.Services.Plugins;
using Nop.Web.Framework.Infrastructure;

namespace Nop.Plugin.Widgets.AskVendor
{
    public class AskVendorPlugin : BasePlugin, IWidgetPlugin
    {
        // widget listesinde widget'ın görünüp görünmeyeceğini belirler. false = görünür, true = görünmez;
        public bool HideInWidgetList => false;

        public Type GetWidgetViewComponent(string widgetZone) //ne gösterilecek
        {
           return typeof(AskVendorViewComponent);
        }

        public async Task<IList<string>> GetWidgetZonesAsync() //nerelerde
        {
            var widgetZones = new List<string> { PublicWidgetZones.ProductDetailsInsideOverviewButtonsAskVendor };
             return await Task.FromResult(widgetZones);
        }
    }
}
