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
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [HttpPost]
        public IActionResult Insert()
        {
            var student = new Student
            {
                Name = this.Name,
                DateOfBirth = this.DateOfBirth
            };
            var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.AddNewStudent(student);
            return View();
        }
       

        [HttpDelete]
        public IActionResult Delete()
        {
            var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.DeleteStudentInfo(this.Id);
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
