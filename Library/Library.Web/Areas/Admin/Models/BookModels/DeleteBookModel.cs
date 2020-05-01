using Library.Framework.BookServices;
using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.BookModels
{
    public class DeleteBookModel :BookBaseModel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Edition { get; set; }

        public DeleteBookModel(IBookService bookService) : base(bookService) { }
        public DeleteBookModel() : base() { }

        public void Delete()
        {
            var book = new Book
            {
                Title = this.Title,
                Author = this.Author,
                PublicationDate = this.PublicationDate,
                Edition = this.Edition

            };

            _bookService.DeleteBook(book);
        }
    }
}
