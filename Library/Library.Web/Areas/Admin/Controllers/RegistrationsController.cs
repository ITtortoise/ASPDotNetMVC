using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Library.Framework.BookRepositories;
using Library.Framework.BookServices;
using Library.Framework.Entity;
using Library.Framework.StudentServices;
using Library.Web.Areas.Admin.Models;
using Library.Web.Areas.Admin.Models.RegistrationModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Library.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RegistrationsController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IStudentService _studentService;
        private readonly IBookService _bookService;
        public RegistrationsController(IConfiguration configuration,IStudentService studentService,IBookService bookService)
        {
            _configuration = configuration;
            _studentService = studentService;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<RegistrationModel>();
            return View(model);
        }
        public IActionResult AddRegistration()
        {
            var model = new CreateRegistrationModel();
            ViewBag.Students = _studentService.GetAllStudent();
            ViewBag.Books = _bookService.GetAllBook();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddRegistration(CreateRegistrationModel model)
        {
            
                model.AddNew();
                return RedirectToAction("Index");
                        
        }

        [HttpGet]
        public IActionResult GetRecords()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<RegistrationModel>();
            var data = model.GetRecords(tableModel);
            return Json(data);
        }

    }
}