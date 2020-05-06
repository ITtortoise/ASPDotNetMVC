using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Library.Framework.Entity;
using Library.Framework.StudentServices;
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
        public RegistrationsController(IConfiguration configuration,IStudentService studentService)
        {
            _configuration = configuration;
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<RegistrationModel>();
            return View(model);
        }
        public IActionResult AddRegistration()
        {
            var model = new CreateRegistrationModel();
            ViewBag.StudentName = _studentService.GetAllStudent();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddRegistration(CreateRegistrationModel model)
        {
            
                model.AddNew();
                return RedirectToAction("Index");
                        
        }

    }
}