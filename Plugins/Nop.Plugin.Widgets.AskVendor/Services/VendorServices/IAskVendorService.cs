using System.Threading.Tasks;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;

namespace Nop.Plugin.Widgets.AskVendor.Services.VendorServices
{
    public interface IAskVendorService
    {
        Task InsertCustomerQuestionAsync(CustomerQuestion customerQuestion);
    }
}
