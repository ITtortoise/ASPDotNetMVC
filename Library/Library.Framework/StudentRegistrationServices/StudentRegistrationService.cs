using Library.Framework.LUnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.StudentRegistrationServices
{
    public class StudentRegistrationService :IStudentRegistrationService
    {
        private ILibraryUnitOfWork _libraryUnitOfWork;

        public StudentRegistrationService(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }

        public void Dispose()
        {
            _libraryUnitOfWork?.Dispose();
        }
    }
}
