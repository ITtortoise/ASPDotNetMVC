using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Library.Web.Areas.Admin.Models;
using Library.Web.Areas.Admin.Models.BookModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Library.Web.Areas.Admin.Controllers
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
            var model = Startup.AutofacContainer.Resolve<BookModel>();
            return View(model);
        }

        public IActionResult AddBook()
        {
            var model = new CreateBookModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult AddBook(CreateBookModel model)
        {
            model.Create();
            return  RedirectToAction("Index");
        }
        public IActionResult DeleteBook()
        {
            var model = new DeleteBookModel();
            return View(model);
        }

        [HttpDelete]
        public IActionResult DeleteBook(DeleteBookModel model)
        {
            model.Delete();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            var tableModel = new DataTablesAjaxRequestModel(Request);
            var model = Startup.AutofacContainer.Resolve<BookModel>();
            var data = model.GetBooks(tableModel);
            return Json(data);
        }
    }
}
