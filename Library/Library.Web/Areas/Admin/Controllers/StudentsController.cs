using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Library.Web.Areas.Admin.Models;
using Library.Web.Areas.Admin.Models.StudentModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Library.Web.Areas.Admin.Controllers
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
            return View(model);
           // return RedirectToAction("Index");
        }
        public IActionResult DeleteStudent()
        {
            var model = new DeleteStudentModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult DeleteStudent(int Id)
        {
            var model = new DeleteStudentModel();
            model.Delete(Id);
           // return View(model);
            return RedirectToAction("Index");  
        }
        public IActionResult UpdateStudent()
        {
            var model = new UpdateStudentModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult UpdateStudent(UpdateStudentModel model)
        {

            model.Modify();
             return View(model);
            //return RedirectToAction("Index");
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