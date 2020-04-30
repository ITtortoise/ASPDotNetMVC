using Library.Framework.Entity;
using Library.Framework.LUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Framework.StudentServices
{
    public class StudentService : IStudentService
    {
        private ILibraryUnitOfWork _libraryUnitOfWork;

        public StudentService(ILibraryUnitOfWork libraryUnitOfWork)
        {
            _libraryUnitOfWork = libraryUnitOfWork;
        }
        public void CreateStudent(Student student)
        {
            _libraryUnitOfWork.StudentRepositroy.Add(student);
            _libraryUnitOfWork.Save();
        }

        public void Dispose()
        {
            _libraryUnitOfWork?.Dispose();
        }

        public (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _libraryUnitOfWork.StudentRepositroy.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
