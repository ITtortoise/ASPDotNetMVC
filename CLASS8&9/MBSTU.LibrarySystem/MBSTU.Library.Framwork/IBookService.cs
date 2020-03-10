using System.Collections.Generic;

namespace MBSTU.Library.Framwork
{
    public interface IBookService
    {
        (IList<Book> records, int total, int totalDisplay) GetBooks(int pageIndex,
                                                                     int pageSize,
                                                                     string searchText,
                                                                     string sortText);
    }
}