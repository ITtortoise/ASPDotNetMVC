using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MBSTU.OnlineCourse.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MBSTU.OnlineCourse.Web.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
            private readonly IConfiguration _configuration;

            public StudentController(IConfiguration configuration)
            {
                _configuration = configuration;
            }
           
            [HttpPost]
            public IActionResult Index(StudentModel model)
            {
                model.CreateStudent();
                return View();
            }

            public IActionResult Privacy()
            {
                return View();
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId =   Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
