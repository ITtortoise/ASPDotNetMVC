using Autofac;
using Library.Framework.BookServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.BookModels
{
    public class BookBaseModel : AdminBaseModel, IDisposable
    {
        protected readonly IBookService _bookService;
        public BookBaseModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        public BookBaseModel()
        {
            _bookService = Startup.AutofacContainer.Resolve<IBookService>();
        }

        public void Dispose()
        {
            _bookService?.Dispose();
        }
    }
}
