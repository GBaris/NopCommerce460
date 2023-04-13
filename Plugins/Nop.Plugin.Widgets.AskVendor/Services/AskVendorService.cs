using System;
using System.Threading.Tasks;
using Nop.Data;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;

namespace Nop.Plugin.Widgets.AskVendor.Services
{
    public class AskVendorService : IAskVendorService
    {
        private readonly IRepository<CustomerQuestion> _customerQuestionRepository;

        public AskVendorService(IRepository<CustomerQuestion> customerQuestionRepository)
        {
            _customerQuestionRepository = customerQuestionRepository;
        }

        public async Task InsertCustomerQuestionAsync(CustomerQuestion customerQuestion)
        {
            if (customerQuestion == null)
                throw new ArgumentNullException(nameof(customerQuestion));

            await _customerQuestionRepository.InsertAsync(customerQuestion);
        }
    }
}
