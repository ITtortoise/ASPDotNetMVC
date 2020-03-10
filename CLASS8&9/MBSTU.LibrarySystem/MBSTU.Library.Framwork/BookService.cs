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
            var books = dbProvider.GetData("select * from Books");

            var filteredBooks = books.Where(x => x.Title.Contains(searchText)
                || x.Author.Contains(searchText));

            var filteredBooksCount = filteredBooks.Count();
            var totalBooks = books.Count();

            var filteredBooksList = filteredBooks.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

            return (filteredBooksList, totalBooks, filteredBooksCount);
        }
    }
}
