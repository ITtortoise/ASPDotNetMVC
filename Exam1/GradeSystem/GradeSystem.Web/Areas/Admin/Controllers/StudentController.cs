using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using GradeSystem.Web.Areas.Admin.Models;
using GradeSystem.Web.Areas.Admin.Models.StudentModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GradeSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentsController : Controller
    {
        private readonly IConfiguration _configuration;
        public StudentsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<StudentModel>();
            return View(model);
        }

        public IActionResult AddStudent()
        {
            var model = new CreateStudentModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddStudent(CreateStudentModel model)
        {
            model.Create();
            return RedirectToAction("Index");
        }
      

        public IActionResult GetStudents()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<StudentModel>();
            var data = model.GetStudents(tableModel);
            return Json(data);
        }
    }
}