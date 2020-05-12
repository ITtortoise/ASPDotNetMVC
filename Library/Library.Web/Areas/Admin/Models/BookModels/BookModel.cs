using Library.Framework.BookServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Web.Areas.Admin.Models.BookModels
{
    public class BookModel : BookBaseModel
    {
        public BookModel(IBookService bookService) : base(bookService) { }
        public BookModel() : base() { }

        internal object GetBooks(DataTablesAjaxRequestModel tableModel)
        {
            var data = _bookService.GetBooks(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Title", "Author", "Edition", "PublicationDate" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                            record.Title,
                            record.Author,
                            record.Edition,
                            record.PublicationDate.ToString(),
                            record.Id.ToString()
                        }
                    ).ToArray()

            };
        }
        internal void Delete(int id)
        {
            _bookService.DeleteBook(id);
           
        }
    }
}
