using Library.Data.BaseUnitOfWork;
using Library.Framework.BookRepositories;
using Library.Framework.ContextModule;
using Library.Framework.StudentRegistrationRepositories;
using Library.Framework.StudentRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.LUnitOfWork
{
    public class LibraryUnitOfWork : UnitOfWork, ILibraryUnitOfWork
    {
        public IStudentRepository StudentRepositroy { get; set; }
        public IBookRepository BookRepositroy { get; set; }
        public IStudentRegistrationRepository StudentRegistrationRepository { get; set; }
        public LibraryUnitOfWork(FrameworkContext context, IBookRepository bookRepositroy,IStudentRepository studentRepository,IStudentRegistrationRepository studentRegistrationRepository)
            : base(context)
        {
            StudentRepositroy = studentRepository;
            BookRepositroy = bookRepositroy;
            StudentRegistrationRepository = studentRegistrationRepository;
        }
    }
}
