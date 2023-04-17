using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nop.Data;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;

namespace Nop.Plugin.Widgets.AskVendor.Services.VendorServices
{
    public class AskVendorService : IAskVendorService
    {
        private readonly IRepository<CustomerQuestion> _customerQuestionRepository;

        public AskVendorService(IRepository<CustomerQuestion> customerQuestionRepository)
        {
            _customerQuestionRepository = customerQuestionRepository;
        }

        public async Task<CustomerQuestion> GetCustomerQuestionByIdAsync(int questionId)
        {
            if (questionId == 0)
                throw new ArgumentNullException(nameof(questionId));

            var customerQuestion = await _customerQuestionRepository.GetByIdAsync(questionId);

            return customerQuestion;
        }

        public async Task<IList<CustomerQuestion>> GetCustomerQuestionsByVendorIdAsync(int vendorId)
        {
            if (vendorId == 0)
                throw new ArgumentNullException(nameof(vendorId));

            var customerQuestions = await _customerQuestionRepository.GetAllAsync(
                query => query.Where(q => q.VendorId == vendorId && !q.IsDeletedByVendor));

            return customerQuestions;
        }

        public async Task InsertCustomerQuestionAsync(CustomerQuestion customerQuestion)
        {
            if (customerQuestion == null)
                throw new ArgumentNullException(nameof(customerQuestion));

            await _customerQuestionRepository.InsertAsync(customerQuestion);
        }

        public async Task UpdateCustomerQuestionAsync(CustomerQuestion customerQuestion)
        {
            if (customerQuestion == null)
                throw new ArgumentNullException(nameof(customerQuestion));

            await _customerQuestionRepository.UpdateAsync(customerQuestion);
        }
    }
}
