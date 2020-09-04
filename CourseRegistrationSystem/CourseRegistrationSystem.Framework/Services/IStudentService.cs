using CourseRegistrationSystem.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Services
{
    public interface IStudentService : IDisposable
    {
        (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex,
                                                                   int pageSize,
                                                                   string searchText,
                                                                   string sortText);
        void CreateStudent(Student newstudent);
        void DeleteStudent(int id);
        Student GetStudentbyId(int id);
        void UpdateStudent(Student student);
    }
}
