using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Plugin.Widgets.AskVendor.Components.CustomerComponents;
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
            if (widgetZone == PublicWidgetZones.ProductDetailsInsideOverviewButtonsAskVendor)
            {
                return typeof(AskVendorViewComponent);
            }
            else if (widgetZone == PublicWidgetZones.HeaderLinkVendorHasMessage)
            {
                return typeof(CustomerHasMessageComponent);
            }

            return null;
        }

        public async Task<IList<string>> GetWidgetZonesAsync() //nerelerde
        {
            var widgetZones = new List<string>
        {
            PublicWidgetZones.ProductDetailsInsideOverviewButtonsAskVendor,
            PublicWidgetZones.HeaderLinkVendorHasMessage
        };

            return await Task.FromResult(widgetZones);
        }
    }
}
