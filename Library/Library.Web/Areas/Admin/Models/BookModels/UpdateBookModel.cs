using Library.Framework.BookServices;
using Library.Framework.Entity;
using Library.Framework.StudentServices;
using Library.Web.Areas.Admin.Models.BookModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.BookModels
{
    public class UpdateBookModel : BookBaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Edition { get; set; }

        public UpdateBookModel(IBookService bookService) : base(bookService) { }
        public UpdateBookModel() : base() { }

        public void Modify()
        {
            var newbook = new Book
            {
                Id = this.Id,
                Title = this.Title,
                Author = this.Author,
                PublicationDate= this.PublicationDate,
                Edition = this.Edition
            };

            var updatebook = _bookService.GetBooksById(Id);
            updatebook.Title = newbook.Title;
            updatebook.Author = newbook.Author;
            updatebook.PublicationDate = newbook.PublicationDate;
            updatebook.Edition = newbook.Edition;
            _bookService.updateBook(updatebook);
           
        }
    }
}
