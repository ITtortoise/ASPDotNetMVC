using CourseRegistrationSystem.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.Services
{
    public interface IStudentRegistrationService : IDisposable
    {
        (IList<StudentRegistration> records, int total, int totalDisplay) GetStudentRegistrations(int pageIndex,
                                                                   int pageSize,
                                                                   string searchText,
                                                                   string sortText);
        void CreateStudentRegistration(StudentRegistration newstudentRegistration);
        void DeleteStudentRegistration(int id);
        StudentRegistration GetStudentRegistrationbyId(int id);
        void EditStudentRegistration(StudentRegistration studentRegistration);
    }
}
