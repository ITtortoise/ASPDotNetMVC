using Library.Framework.BookServices;
using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.BookModels
{
    public class CreateBookModel : BookBaseModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }

        public CreateBookModel(IBookService bookService) : base(bookService) { }
        public CreateBookModel() : base() { }

        public void Create()
        {
            var book = new Book
            {
                Title = this.Title,
                Author = this.Author,
                Edition = this.Edition,
                PublicationDate = DateTime.Now
            };

            _bookService.CreateBook(book);
        }
    }
}
