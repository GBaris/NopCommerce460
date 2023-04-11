using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;
using Nop.Plugin.Widgets.AskVendor.Services;
using Nop.Services.Customers;
using Nop.Web.Framework.Controllers;

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
        public async Task<IActionResult> AskQuestion([FromBody] CustomerQuestion model)
        {
            var currentCustomer = await _customerService.GetCustomerByEmailAsync(User.Identity.Name);

            var customerQuestion = new CustomerQuestion
            {
                CustomerId = currentCustomer.Id,
                VendorId = model.VendorId,
                ProductId = model.ProductId,
                Question = model.Question,
                CreatedOnUtc = DateTime.Now
            };

            await _askVendorService.InsertCustomerQuestionAsync(customerQuestion);

            return Json(new { success = true });
        }

    }
}
