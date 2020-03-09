using System.Linq;

namespace MBSTU.LibrarySystem.WEB.Areas.Admin.Models
{
    public class BooksModel : AdminBaseModel
    {
        private readonly IBookService  _bookservice;
        public BooksModel()
        {
            _bookservice = new BookService();
        }

        internal object GetBooks(DataTablesAjaxRequestModel tableModel)
        {
            var data = _bookService.GetBooks(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText);

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
                                record.PublicationDate.ToString()
                        }
                    ).ToArray()

            };
        }
    }

    
}
