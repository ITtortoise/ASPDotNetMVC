using Library.Framework.Entity;
using Library.Framework.LUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Framework.BookServices
{
    public class BookService : IBookService
    {
        private ILibraryUnitOfWork _libraryUnitOfWork;

        public BookService(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }
        public void CreateBook(Book book)
        {
            _libraryUnitOfWork.BookRepositroy.Add(book);
            _libraryUnitOfWork.Save();
        }

        public void DeleteBook(Book book)
        {
            _libraryUnitOfWork.BookRepositroy.Remove(book);
        }

        public void Dispose()
        {
            _libraryUnitOfWork?.Dispose();
        }

        public (IList<Book> records, int total, int totalDisplay) GetBooks(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _libraryUnitOfWork.BookRepositroy.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
