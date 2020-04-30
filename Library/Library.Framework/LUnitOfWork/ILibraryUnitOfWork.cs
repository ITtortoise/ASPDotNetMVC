using Library.Data.BaseUnitOfWork;
using Library.Framework.BookRepositories;
using Library.Framework.StudentRegistrationRepositories;
using Library.Framework.StudentRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.LUnitOfWork
{
    public interface ILibraryUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepositroy { get; set; }
        IBookRepository BookRepositroy { get; set; }
        //IStudentRegistrationRepository StudentRegistrationRepository { get; set; }

    }
}
