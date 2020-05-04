using Library.Framework.BookServices;
using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.BookModels
{
    public class DeleteBookModel : BookBaseModel
    {
        public int Id { get; set; }
        public DeleteBookModel(IBookService bookService) : base(bookService) { }
        public DeleteBookModel() : base() { }

        public void Delete(int Id)
        {

            _bookService.DelBook(Id);
        }
    }
}
