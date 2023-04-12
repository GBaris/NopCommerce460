using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;
using Nop.Plugin.Widgets.AskVendor.Services;
using Nop.Services.Customers;
using Nop.Web.Framework;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Widgets.AskVendor.Controllers
{
    public class AskVendorController : BasePluginController
    {
        private readonly IAskVendorService _askVendorService;
        private readonly ICustomerService _customerService;

        public AskVendorController(IAskVendorService askVendorService, ICustomerService customerService)
        {
            _askVendorService = askVendorService;
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<IActionResult> AskQuestion(int vendorId, int productId /*string subject, string message*/)
        {
            var currentCustomer = await _customerService.GetCustomerByEmailAsync(User.Identity.Name);

            var customerQuestion = new CustomerQuestion
            {
                CustomerId = currentCustomer.Id,
                VendorId = vendorId,
                ProductId = productId,
                //Question = subject + " " + message,
                //CreatedOnUtc = DateTime.Now
            };

            await _askVendorService.InsertCustomerQuestionAsync(customerQuestion);

            return RedirectToAction("ProductDetails", "Product", new { productId = productId });
        }
    }
}
