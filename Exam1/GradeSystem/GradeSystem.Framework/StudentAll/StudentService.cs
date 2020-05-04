using GradeSystem.Framework.Entity;
using GradeSystem.Framework.GradeUnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeSystem.Framework.StudentAll
{
    public class StudentService : IStudentService
    {
        private IGradingUnitOfWork _gradingUnitOfWork;

        public StudentService(GradingUnitOfWork gradingUnitOfWork)
        {
            _gradingUnitOfWork = gradingUnitOfWork;
        }
        public void CreateStudent(Student student)
        {
            _gradingUnitOfWork.StudentRepository.Add(student);
            _gradingUnitOfWork.Save();
        }
        public void Dispose()
        {
            _gradingUnitOfWork?.Dispose();
        }

        public (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _gradingUnitOfWork.StudentRepository.GetAll().ToList();
            return (result, 0, 0);
        }

    }
}
