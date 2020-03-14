using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MBSTU.Library.Data;

namespace MBSTU.Library.Framwork
{
    public class BookService : IBookService
    {
      
        private string _connectionString;

        public BookService(string connectionString)
        {
            _connectionString = connectionString;
        }


        public (IList<Book> records, int total, int totalDisplay) GetBooks(int pageIndex,
             int pageSize, string searchText, string sortText)
        {
            using var dbProvider = new SqlServerDataProvider<Book>(_connectionString);
            var books = dbProvider.GetData("GetBooks", new List<(string, object, bool)>
            {
                ("PageIndex", pageIndex, false),
                ("PageSize", pageSize , false),
                ("SearchText", searchText , false),
                ("OrderBy", sortText, false),
                ( "Total", 0, true),
                ( "TotalDisplay", 0, true)
            });

            return (books.result, books.total, books.totalDisplay);
        }
    }
}
