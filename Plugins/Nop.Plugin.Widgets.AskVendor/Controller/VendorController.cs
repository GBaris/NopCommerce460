using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nop.Core.Domain.Customers;
using Nop.Plugin.Widgets.AskVendor.Data.Domain;
using Nop.Plugin.Widgets.AskVendor.Services.VendorServices;
using Nop.Services.Customers;
using Nop.Web.Framework.Controllers;
using Nop.Web.Framework.Mvc.Filters;

namespace Nop.Plugin.Widgets.AskVendor.Controller
{
    [AuthorizeAdmin]
    [Area("Admin")]
    [AutoValidateAntiforgeryToken]
    public class VendorController : BasePluginController
    {
        private readonly IAskVendorService _askVendorService;
        private readonly ICustomerService _customerService;

        public VendorController(IAskVendorService askVendorService, ICustomerService customerService)
        {
            _askVendorService = askVendorService;
            _customerService = customerService;
        }

        public async Task<IActionResult> Questions()
        {
            var currentVendorId = (await _customerService.GetCustomerByEmailAsync(User.Identity.Name)).VendorId;
            var questions = await _askVendorService.GetCustomerQuestionsByVendorIdAsync(currentVendorId);

            return View("~/Plugins/Widgets.AskVendor/Views/VendorViews/Questions.cshtml", questions);
        }

        [HttpPost]
        public async Task<IActionResult> AnswerQuestion(int questionId, string answer)
        {
            var customerQuestion = await _askVendorService.GetCustomerQuestionByIdAsync(questionId);
            customerQuestion.Answer = answer;
            customerQuestion.AnswerDate = DateTime.UtcNow;
            customerQuestion.IsAnswered = true;

            await _askVendorService.UpdateCustomerQuestionAsync(customerQuestion);

            return RedirectToAction("Questions");
        }
    }
}
