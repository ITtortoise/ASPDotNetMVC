using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MBSTU.LibrarySystem.WEB.Areas.User.Controllers
{
    [Area("User")]
    public class FrontEndController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}