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

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(StudentModel Model)
        {
            Model.NewStudent();
            return View();
        }
        [HttpPut]
        public IActionResult Index(String name ,DateTime dateTime)
        {
            var student = new Student
            {
                Name =name,
                DateOfBirth = dateTime
            };
            var  Model = new StudentModel();
            Model.UpdateStudent(student);
            return View();
        }
        [HttpDelete]
        public IActionResult Index(int id)
        {
            var Model = new StudentModel();
            Model.DeleteStudent(id);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
