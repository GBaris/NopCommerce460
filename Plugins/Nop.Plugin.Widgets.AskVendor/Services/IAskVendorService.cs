using System.Threading.Tasks;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;

namespace Nop.Plugin.Widgets.AskVendor.Services
{
    public interface IAskVendorService
    {
        Task InsertCustomerQuestionAsync(CustomerQuestion customerQuestion);
    }
}
