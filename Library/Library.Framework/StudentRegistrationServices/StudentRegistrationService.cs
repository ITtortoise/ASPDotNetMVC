using Library.Framework.Entity;
using Library.Framework.LUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public void AddNewRecord(StudentRegistration newRecord)
        {
            _libraryUnitOfWork.StudentRegistrationRepository.Add(newRecord);
            _libraryUnitOfWork.Save();
        }

        public void Dispose()
        {
            _libraryUnitOfWork?.Dispose();
        }

        public (IList<StudentRegistration> records, int total, int totalDisplay) GetRecords(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _libraryUnitOfWork.StudentRegistrationRepository.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
