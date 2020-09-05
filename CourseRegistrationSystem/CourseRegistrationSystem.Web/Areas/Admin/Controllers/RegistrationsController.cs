using Autofac;
using CourseRegistrationSystem.Framework.MenuSessionExceptionFiles;
using CourseRegistrationSystem.Web.Areas.Admin.Models;
using CourseRegistrationSystem.Web.Areas.Admin.Models.StudentRegistrationModelFiles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace CourseRegistrationSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RegistrationsController : Controller
    {
        public readonly IConfiguration _configuration;
        public RegistrationsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<StudentRegistrationModel>();
            return View(model);
        }
        public IActionResult AddStudentRegistration()
        {
            var model = new CreateStudentRegistrationModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudentRegistration(
            [Bind(nameof(CreateStudentRegistrationModel.StudentId),
            nameof(CreateStudentRegistrationModel.CourseId),
            nameof(CreateStudentRegistrationModel.EnrollDate),
            nameof(CreateStudentRegistrationModel.IsPaymentComplete))] CreateStudentRegistrationModel model)
        {
            ModelState.Remove("Id");

            if (ModelState.IsValid)
            {
                try
                {
                    model.Create();
                    model.Response = new ResponseModel("Registration successful.", ResponseType.Success);
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
                    model.Response = new ResponseModel("Registration failed.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        public IActionResult EditStudentRegistration(int id)
        {
            var model = new EditStudentRegistrationModel();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditStudentRegistration(
            [Bind (nameof(EditStudentRegistrationModel.Id),
            nameof(EditStudentRegistrationModel.StudentId),
            nameof(EditStudentRegistrationModel.CourseId),
            nameof(EditStudentRegistrationModel.EnrollDate),
            nameof(EditStudentRegistrationModel.IsPaymentComplete))] EditStudentRegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Edit();
                    model.Response = new ResponseModel("Registration record update successful.", ResponseType.Success);
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
                    model.Response = new ResponseModel("Registration record update failed.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteStudentRegistration(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new StudentRegistrationModel();
                try
                {
                    model.Delete(id);
                    model.Response = new ResponseModel($"StudentRegistration successfully deleted.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("StudentRegistration delete failued.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult GetStudentRegistrations()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<StudentRegistrationModel>();
            var data = model.GetStudentRegistrations(tableModel);
            return Json(data);
        }
    }
}