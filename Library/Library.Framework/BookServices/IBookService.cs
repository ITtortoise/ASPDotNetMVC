using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.BookServices
{
    public interface IBookService : IDisposable
    {
        (IList<Book> records, int total, int totalDisplay) GetBooks(int pageIndex,
                                                                    int pageSize,
                                                                    string searchText,
                                                                    string sortText);
        void CreateBook(Book book);
        void DelBook(int id);
        Book GetBooksById(int id);
        void updateBook(Book updatebook);       
        IList<Book> GetAllBook();
    }
}
