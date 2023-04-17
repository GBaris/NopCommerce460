using System.Collections.Generic;
using System.Threading.Tasks;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;

namespace Nop.Plugin.Widgets.AskVendor.Services.VendorServices
{
    public interface IAskVendorService
    {
        Task InsertCustomerQuestionAsync(CustomerQuestion customerQuestion);
        Task UpdateCustomerQuestionAsync(CustomerQuestion customerQuestion);
        Task<IList<CustomerQuestion>> GetCustomerQuestionsByVendorIdAsync(int vendorId);
        Task<CustomerQuestion> GetCustomerQuestionByIdAsync(int questionId);
    }
}
