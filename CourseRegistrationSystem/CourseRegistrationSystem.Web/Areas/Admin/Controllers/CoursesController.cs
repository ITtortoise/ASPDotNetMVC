using System;
using Autofac;
using CourseRegistrationSystem.Framework.MenuSessionExceptionFiles;
using CourseRegistrationSystem.Web.Areas.Admin.Models;
using CourseRegistrationSystem.Web.Areas.Admin.Models.CourseModelFiles;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CourseRegistrationSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CoursesController : Controller
    {
        public readonly IConfiguration _configuration;
        public CoursesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<CourseModel>();
            return View(model);
        }
        public IActionResult AddCourse()
        {
            var model = new CreateCourseModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddCourse(
            [Bind(nameof(CreateCourseModel.Title),
            nameof(CreateCourseModel.SeatCount),
            nameof(CreateCourseModel.Fee))] CreateCourseModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Create();
                    model.Response = new ResponseModel("Course creation successful.", ResponseType.Success);
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
                    model.Response = new ResponseModel("Course creation failed.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        public IActionResult EditCourse(int id)
        {
            var model = new EditCourseModel();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditCourse(
            [Bind (nameof(EditCourseModel.Id),
            nameof(EditCourseModel.Title),
            nameof(EditCourseModel.SeatCount),
            nameof(EditCourseModel.Fee))] EditCourseModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Edit();
                    model.Response = new ResponseModel("Course record update successful.", ResponseType.Success);
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
                    model.Response = new ResponseModel("Course record update failed.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCourse(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new CourseModel();
                try
                {
                    model.Delete(id);
                    model.Response = new ResponseModel($"Course successfully deleted.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Course delete failued.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult GetCourses()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<CourseModel>();
            var data = model.GetCourses(tableModel);
            return Json(data);
        }
    }
}
