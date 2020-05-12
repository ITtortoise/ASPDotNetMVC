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
            var count = _libraryUnitOfWork.BookRepositroy.GetCount(x => x.Title == book.Title);
            if (count > 0)
                throw new DuplicationException("Book title already exists", nameof(book.Title));
            _libraryUnitOfWork.BookRepositroy.Add(book);
            _libraryUnitOfWork.Save();
        }

        public void EditBook(Book book)
        {
            var count = _libraryUnitOfWork.BookRepositroy.GetCount(x => x.Title == book.Title
                    && x.Id != book.Id);

            if (count > 0)
                throw new DuplicationException("Book title already exists", nameof(book.Title));

            var existingBook = _libraryUnitOfWork.BookRepositroy.GetById(book.Id);
            existingBook.Author = book.Author;
            existingBook.Edition = book.Edition;
            existingBook.PublicationDate = book.PublicationDate;
            existingBook.Title = book.Title;

            _libraryUnitOfWork.Save();
        }

        public Book GetBook(int id)
        {
            return _libraryUnitOfWork.BookRepositroy.GetById(id);
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

        public void DeleteBook(int id)
        {
           //var book = _libraryUnitOfWork.BookRepositroy.GetById(id);
            _libraryUnitOfWork.BookRepositroy.Remove(id);
            _libraryUnitOfWork.Save();
            //return book;
        }
    }
}
