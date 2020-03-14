using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MBSTU.LibrarySystem.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MBSTU.LibrarySystem.WEB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly IConfiguration _configuration;
        public BooksController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var model = new BooksModel(_configuration);
            return View(model);
        }

        public IActionResult GetBooks()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = new BooksModel(_configuration);
            var data = model.GetBooks(tableModel);
            return Json(data);
        }
    }
}