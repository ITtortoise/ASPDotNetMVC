using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GradeSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GradesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}