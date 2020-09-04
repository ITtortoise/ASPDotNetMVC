using Autofac;
using CourseRegistrationSystem.Framework.MenuSessionExceptionFiles;
using CourseRegistrationSystem.Web.Areas.Admin.Models;
using CourseRegistrationSystem.Web.Areas.Admin.Models.StudentModelFiles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace CourseRegistrationSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentsController : Controller
    {
        public readonly IConfiguration _configuration;
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
        [ValidateAntiForgeryToken]
        public IActionResult AddStudent(
            [Bind(nameof(CreateStudentModel.Name),
            nameof(CreateStudentModel.DateOfBirth))] CreateStudentModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Create();
                    model.Response = new ResponseModel("Student creation successful.", ResponseType.Success);
                    //return View(model);
                    return RedirectToAction("Index");
                }
                catch (DuplicationException ex)
                {
                    model.Response = new ResponseModel(ex.Message, ResponseType.Failure);
                    // error logger code
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Student creation failed.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        public IActionResult EditStudent(int id)
        {
            var model = new EditStudentModel();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditStudent(
            [Bind (nameof(EditStudentModel.Id),
            nameof(EditStudentModel.Name),
            nameof(EditStudentModel.DateOfBirth))] EditStudentModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Edit();
                    model.Response = new ResponseModel("Student record update successful.", ResponseType.Success);
                    //return View(model);
                    return RedirectToAction("Index");
                }
                catch (DuplicationException ex)
                {
                    model.Response = new ResponseModel(ex.Message, ResponseType.Failure);
                    // error logger code
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Student record update failed.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStudent(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new StudentModel();
                try
                {
                    model.Delete(id);
                    model.Response = new ResponseModel($"Student successfully deleted.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Student delete failued.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult GetStudents()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<StudentModel>();
            var data = model.GetStudents(tableModel);
            return Json(data);
        }
    }
}