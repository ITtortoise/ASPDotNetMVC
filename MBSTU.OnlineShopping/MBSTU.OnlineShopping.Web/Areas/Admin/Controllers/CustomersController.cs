using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MBSTU.OnlineShopping.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MBSTU.OnlineShopping.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new CustomerModel();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddOrEdit(int? id)
        {
            var model = new CustomerModel();

            #region for edit
            if (id.HasValue && id != 0)
            {
                await model.LoadByIdAsync(id.Value);
            }
            #endregion

            return PartialView("_AddOrEdit", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(CustomerModel model)
        {
            ModelState.Remove("Id");

            if (ModelState.IsValid)
            {
                if (model.Id == null || model.Id == 0) await model.AddAsync();
                else await model.UpdateAsync();

                TempData["SuccessNotify"] = "Customer has been successfully saved";
                return RedirectToAction("Index");
            }

            TempData["ErrorNotify"] = "Customer could not be saved";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var model = new CustomerModel();
            await model.DeleteAsync(id);
            return Json(true);
        }

        public async Task<IActionResult> GetCustomers()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = new CustomerModel();
            var data = await model.GetAllAsync(tableModel);
            return Json(data);
        }
    }
}