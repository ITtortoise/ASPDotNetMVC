using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MBSTU.OnlineCourse.Web.Models;
using Microsoft.Extensions.Configuration;
using MBSTU.OnlineCourse.Framework.Entity;
using Autofac;
using MBSTU.OnlineCourse.Framework.Interface;
using MBSTU.OnlineCourse.Web.Areas.Admin.Models;
using StudentModel = MBSTU.OnlineCourse.Web.Areas.Admin.Models.StudentModel;

namespace MBSTU.OnlineCourse.Web.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insert(StudentModel model)
        {
            model.NewStudent();
            return View();
        }
       
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            return Redirect("/Student/Insert");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
