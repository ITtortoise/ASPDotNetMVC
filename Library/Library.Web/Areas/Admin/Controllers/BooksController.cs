using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Library.Framework;
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
        [ValidateAntiForgeryToken]
        public IActionResult AddBook(
            [Bind(nameof(CreateBookModel.Title),
            nameof(CreateBookModel.Author),
            nameof(CreateBookModel.Edition))] CreateBookModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Create();
                    model.Response = new ResponseModel("Book creation successful.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (DuplicationException ex)
                {
                    model.Response = new ResponseModel(ex.Message, ResponseType.Failure);
                    // error logger code
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Book creation failued.", ResponseType.Failure);
                    // error logger code
                }
            }
            return View(model);
        }
        public IActionResult UpdateBook(int id)
        {
            var model = new UpdateBookModel();
            model.Load(id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateBook(
            [Bind(nameof(UpdateBookModel.Id),
            nameof(UpdateBookModel.Title),
            nameof(UpdateBookModel.Author),
            nameof(UpdateBookModel.Edition))] UpdateBookModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.Edit();
                    model.Response = new ResponseModel("Book creation successful.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (DuplicationException ex)
                {
                    model.Response = new ResponseModel(ex.Message, ResponseType.Failure);
                    // error logger code
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Book creation failued.", ResponseType.Failure);
                    // error logger code
                }
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBook(int id)
        {
            if (ModelState.IsValid)
            {
                var model = new BookModel();
                try
                {
                    model.Delete(id);
                    model.Response = new ResponseModel($"Book successfully deleted.", ResponseType.Success);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    model.Response = new ResponseModel("Book delete failued.", ResponseType.Failure);
                    // error logger code
                }
            }
            return RedirectToAction("index");
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
