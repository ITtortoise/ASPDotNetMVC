using Library.Data.BaseRepository;
using Library.Framework.ContextModule;
using Library.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.BookRepositories
{
    public class BookRepository : Repository<Book, int, FrameworkContext>, IBookRepository
    {
        public BookRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }

      
    }
}
