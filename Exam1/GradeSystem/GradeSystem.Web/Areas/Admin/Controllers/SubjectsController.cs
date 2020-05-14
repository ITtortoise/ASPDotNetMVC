using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using GradeSystem.Framework.ResponseFile;
using GradeSystem.Web.Areas.Admin.Models;
using GradeSystem.Web.Areas.Admin.Models.SubjectModelFile;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GradeSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SubjectsController : Controller
    {
        public readonly IConfiguration _configuration;
        public SubjectsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            var model = Startup.AutofacContainer.Resolve<SubjectModel>();
            return View(model);
        }
        public IActionResult AddSubject()
        {
            var model = new CreateSubjectModel();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddSubject(
            [Bind(nameof(CreateSubjectModel.Name),
            nameof(CreateSubjectModel.RegistrationOpen))] CreateSubjectModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Create();
                    model.Response = new ResponseModel("Subject creation successful.", ResponseType.Success);
                    return RedirectToAction("index");
                    //return RedirectToAction("Index");
                }
                catch (DuplicationException ex)
                {
                    model.Response = new ResponseModel(ex.Message, ResponseType.Failure);
                    // error logger code
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Subject creation failed.", ResponseType.Failure);
                    // error logger code
                }
            }
            return View(model);
        }
        public IActionResult EditSubject(int id)
        {
            var model = new EditSubjectModel();
            model.Load(id);
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSubject(
            [Bind (nameof(EditSubjectModel.Id),
            nameof(EditSubjectModel.Name),
            nameof(EditSubjectModel.RegistrationOpen))] EditSubjectModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Edit();
                    model.Response = new ResponseModel("Subject record update successful.", ResponseType.Success);
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
                    model.Response = new ResponseModel("Subject record update failed.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteSubject(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new SubjectModel();
                try
                {
                    model.Delete(id);
                    model.Response = new ResponseModel($"Subject successfully deleted.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Subject delete failued.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult GetSubjects()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<SubjectModel>();
            var data = model.GetSubjects(tableModel);
            return Json(data);
        }
    }
}